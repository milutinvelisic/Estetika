using Estetika.Application.DataTransfer;
using Estetika.Application.Queries;
using Estetika.Application.Searches;
using Estetika.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Queries
{
    public class EfGetEKartonQuery : IGetEKartonQuery
    {
        private readonly EstetikaContext _context;

        public EfGetEKartonQuery(EstetikaContext context)
        {
            _context = context;
        }
        public int Id => 43;

        public string Name => "Search EKarton using EF";

        public PagedResponse<EkartonDto> Execute(EKartonSearch search)
        {
            var query = _context.EKartons.Include(x => x.Dentist).Include(x => x.ServiceTypes).Include(x => x.User).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.FirstName) || !string.IsNullOrEmpty(search.FirstName))
            {
                query = query.Where(x => x.User.FirstName.ToLower().Contains(search.FirstName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search.LastName) || !string.IsNullOrEmpty(search.LastName))
            {
                query = query.Where(x => x.User.LastName.ToLower().Contains(search.LastName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search.DentistFirstName) || !string.IsNullOrEmpty(search.DentistFirstName))
            {
                query = query.Where(x => x.Dentist.FirstName.ToLower().Contains(search.DentistFirstName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search.DentistLastName) || !string.IsNullOrEmpty(search.DentistLastName))
            {
                query = query.Where(x => x.Dentist.LastName.ToLower().Contains(search.DentistLastName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search.Service) || !string.IsNullOrEmpty(search.Service))
            {
                query = query.Where(x => x.ServiceTypes.ServiceName.ToLower().Contains(search.Service.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<EkartonDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new EkartonDto
                {
                    Date = x.Date,
                    ServiceTypeId = x.ServiceTypeId,
                    UserId = x.UserId,
                    DentistId = x.DentistId,
                    Price = x.Price,
                    JawJawSideToothId = x.JawJawSideToothId
                }).ToList()
            };

            return response;
        }
    }
}
