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
    public class EfGetAppointmentQuery : IGetAppointmentQuery
    {
        private readonly EstetikaContext _context;

        public EfGetAppointmentQuery(EstetikaContext context)
        {
            _context = context;
        }
        public int Id => 46;

        public string Name => "Search Appointments using EF";

        public PagedResponse<AppointmentDto> Execute(AppointmentSearch search)
        {
            var query = _context.Appointments.Include(x => x.ServiceTypes).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.FirstNameLastName) || !string.IsNullOrEmpty(search.FirstNameLastName))
            {
                query = query.Where(x => x.FirstNameLastName.ToLower().Contains(search.FirstNameLastName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search.Service) || !string.IsNullOrEmpty(search.Service))
            {
                query = query.Where(x => x.ServiceTypes.ServiceName.ToLower().Contains(search.Service.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search.Service) || !string.IsNullOrEmpty(search.Service))
            {
                query = query.Where(x => x.ServiceTypes.ServiceDescription.ToLower().Contains(search.Service.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<AppointmentDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new AppointmentDto
                {
                    FirstNameLastName = x.FirstNameLastName,
                    Date = x.Date,
                    Time = x.Time,
                    ServiceTypeId = x.ServiceTypeId,
                    Email = x.Email,
                    Phone = x.Phone
                }).ToList()
            };

            return response;
        }
    }
}
