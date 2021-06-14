using Estetika.Application.DataTransfer;
using Estetika.Application.Queries;
using Estetika.Application.Searches;
using Estetika.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Queries
{
    public class EfGetDentistQuery : IGetDentistQuery
    {
        private readonly EstetikaContext _context;

        public EfGetDentistQuery(EstetikaContext context)
        {
            _context = context;
        }
        public int Id => 22;

        public string Name => "Search Dentist using EF";

        public PagedResponse<DentistDto> Execute(DentistSearch search)
        {
            var query = _context.Dentists.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.FirstName) || !string.IsNullOrEmpty(search.FirstName))
            {
                query = query.Where(x => x.FirstName.ToLower().Contains(search.FirstName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search.LastName) || !string.IsNullOrEmpty(search.LastName))
            {
                query = query.Where(x => x.LastName.ToLower().Contains(search.LastName.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<DentistDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new DentistDto
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName
                }).ToList()
            };

            return response;
        }
    }
}
