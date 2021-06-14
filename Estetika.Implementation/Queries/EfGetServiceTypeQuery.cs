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
    public class EfGetServiceTypeQuery : IGetServiceTypeQuery
    {
        private readonly EstetikaContext _context;

        public EfGetServiceTypeQuery(EstetikaContext context)
        {
            _context = context;
        }

        public int Id => 20;

        public string Name => "Search ServiceTypes using EF";

        public PagedResponse<ServiceTypeDto> Execute(ServiceTypeSearch search)
        {
            var query = _context.ServiceTypes.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.ServiceName) || !string.IsNullOrEmpty(search.ServiceName))
            {
                query = query.Where(x => x.ServiceName.ToLower().Contains(search.ServiceName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search.ServiceDescription) || !string.IsNullOrEmpty(search.ServiceDescription))
            {
                query = query.Where(x => x.ServiceDescription.ToLower().Contains(search.ServiceDescription.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<ServiceTypeDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new ServiceTypeDto
                {
                    ServiceName = x.ServiceName,
                    ServiceDescription = x.ServiceDescription
                }).ToList()
            };

            return response;
        }
    }
}
