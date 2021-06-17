using Estetika.Application;
using Estetika.Application.DataTransfer;
using Estetika.Application.Queries;
using Estetika.Application.Searches;
using Estetika.DataAccess;
using Estetika.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Queries
{
    public class EfGetUseCaseLogQuery : IGetUseCaseLogQuery
    {
        private readonly EstetikaContext _context;

        public EfGetUseCaseLogQuery(EstetikaContext context)
        {
            _context = context;
        }
        public int Id => 45;

        public string Name => "Search UseCaseLog using EF";

        public PagedResponse<UseCaseLogDto> Execute(UseCaseSearchSearch search)
        {
            var query = _context.UseCaseLog.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.UseCaseName) || !string.IsNullOrEmpty(search.UseCaseName))
            {
                query = query.Where(x => x.UseCaseName.ToLower().Contains(search.UseCaseName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search.Actor) || !string.IsNullOrEmpty(search.Actor))
            {
                query = query.Where(x => x.Actor.ToLower().Contains(search.Actor.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<UseCaseLogDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new UseCaseLogDto
                {
                    UseCaseName = x.UseCaseName,
                    Actor = x.Actor,
                    Date = x.Date,
                    Data = x.Data,
                }).ToList()
            };

            return response;
        }
    }
}
