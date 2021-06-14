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
    public class EfGetOneRoleQuery : IGetOneRoleQuery
    {
        private readonly EstetikaContext _context;

        public EfGetOneRoleQuery(EstetikaContext context)
        {
            _context = context;
        }

        public int Id => 20;

        public string Name => "Get one role using EF";

        public RoleDto Execute(int search)
        {
            var role = _context.Roles.Find(search);

            if (role == null) throw new EntityNotFoundException(search, typeof(Role));

            return new RoleDto
            {
                Id = search,
                RoleName = role.RoleName
            };
        }
    }
}
