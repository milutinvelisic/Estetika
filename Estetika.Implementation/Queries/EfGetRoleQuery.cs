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
    public class EfGetRoleQuery : IGetRoleQuery
    {
        private readonly EstetikaContext _context;

        public EfGetRoleQuery(EstetikaContext context)
        {
            _context = context;
        }

        public int Id => 19;

        public string Name => "Search roles using EF";

        public PagedResponse<RoleDto> Execute(RoleSearch search)
        {
            var query = _context.Roles.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.RoleName) || !string.IsNullOrEmpty(search.RoleName))
            {
                query = query.Where(x => x.RoleName.ToLower().Contains(search.RoleName.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<RoleDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new RoleDto
                {
                    RoleName = x.RoleName
                }).ToList()
            };

            return response;
        }
    }
}
