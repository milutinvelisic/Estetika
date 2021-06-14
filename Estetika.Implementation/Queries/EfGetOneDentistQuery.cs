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
    public class EfGetOneDentistQuery : IGetOneDentistQuery
    {
        private readonly EstetikaContext _context;

        public EfGetOneDentistQuery(EstetikaContext context)
        {
            _context = context;
        }
        public int Id => 23;

        public string Name => "Get one dentist using EF";

        public DentistDto Execute(int search)
        {
            var dentist = _context.Dentists.Find(search);

            if (dentist == null) throw new EntityNotFoundException(search, typeof(Dentist));

            return new DentistDto
            {
                Id = search,
                FirstName = dentist.FirstName,
                LastName = dentist.LastName
            };
        }
    }
}
