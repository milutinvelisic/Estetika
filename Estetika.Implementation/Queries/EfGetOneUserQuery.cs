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
    public class EfGetOneUserQuery : IGetOneUserQuery
    {
        private readonly EstetikaContext _context;

        public EfGetOneUserQuery(EstetikaContext context)
        {
            _context = context;
        }
        public int Id => 36;

        public string Name => "Get one user using EF";

        public UserDto Execute(int search)
        {
            var dentist = _context.Users.Find(search);

            if (dentist == null) throw new EntityNotFoundException(search, typeof(User));

            return new UserDto
            {
                Id = search,
                FirstName = dentist.FirstName,
                LastName = dentist.LastName,
                Email = dentist.Email,
                Phone = dentist.Phone
            };
        }
    }
}
