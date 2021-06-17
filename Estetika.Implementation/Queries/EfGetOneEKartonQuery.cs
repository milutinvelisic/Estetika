using Estetika.Application.DataTransfer;
using Estetika.Application.Exceptions;
using Estetika.Application.Queries;
using Estetika.DataAccess;
using Estetika.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Queries
{
    public class EfGetOneEKartonQuery : IGetOneEKartonQuery
    {
        private readonly EstetikaContext _context;

        public EfGetOneEKartonQuery(EstetikaContext context)
        {
            _context = context;
        }
        public int Id => 44;

        public string Name => "Search one ekarton using EF";

        public EkartonDto Execute(int search)
        {
            var ekarton = _context.EKartons.Find(search);

            if (ekarton == null) throw new EntityNotFoundException(search, typeof(EKarton));

            return new EkartonDto
            {
                Id = ekarton.Id,
                Date = ekarton.Date,
                ServiceTypeId = ekarton.ServiceTypeId,
                Price = ekarton.Price,
                JawJawSideToothId = ekarton.JawJawSideToothId,
                UserId = ekarton.UserId,
                DentistId = ekarton.DentistId,
            };
        }
    }
}
