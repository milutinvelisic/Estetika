using Estetika.Application.Commands;
using Estetika.Application.DataTransfer;
using Estetika.Application.Exceptions;
using Estetika.DataAccess;
using Estetika.Domain;
using Estetika.Implementation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Commands
{
    public class EfUpdateRoleCommand : IUpdateRoleCommand
    {
        private readonly EstetikaContext _context;
        private readonly UpdateRoleValidator validator;

        public EfUpdateRoleCommand(EstetikaContext context, UpdateRoleValidator validator)
        {
            this._context = context;
            this.validator = validator;
        }

        public int Id => 3;

        public string Name => "Update Role using EF";

        public void Execute(RoleDto request)
        {
        
            var role = _context.Roles.Find(request.Id);

            if (role == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Role));
            }

            validator.ValidateAndThrow(request);

            role.RoleName = request.RoleName;

            _context.SaveChanges();

        }
    }
}
