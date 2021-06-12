using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estetika.Application.Commands;
using Estetika.Application.Exceptions;
using Estetika.DataAccess;
using Estetika.Domain;

namespace Estetika.Implementation.Commands
{
    public class EfDeleteRoleCommand : IDeleteRoleCommand
    {
        private readonly EstetikaContext _context;

        public EfDeleteRoleCommand(EstetikaContext context)
        {
            _context = context;
        }

        public int Id => 2;

        public string Name => "Delete Role using EF";

        public void Execute(int request)
        {
            var role = _context.Roles.Find(request);
            if(role == null)
            {
                throw new EntityNotFoundException(request, typeof(Role));
            }

            role.DeletedAt = DateTime.Now;
            role.IsDeleted = true;
            role.IsActive = false;

            _context.SaveChanges();

        }
    }
}
