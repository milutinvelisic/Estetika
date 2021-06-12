using Estetika.Application.Commands;
using Estetika.Application.DataTransfer;
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
    public class EfCreateRoleCommand : ICreateRoleCommand
    {
        private readonly EstetikaContext _context;
        private readonly CreateRoleValidator validator;

        public EfCreateRoleCommand(EstetikaContext context, CreateRoleValidator validator)
        {
            this._context = context;
            this.validator = validator;
        }

        public int Id => 1;

        public string Name => "Create New Role using EF";

        public void Execute(RoleDto request)
        {
            //validator.ValidateAndThrow(request);

            var result = validator.Validate(request);
            if (!result.IsValid)
            {
                throw new ArgumentException(result.ToString());
            }

            var role = new Role
            {
                RoleName = request.RoleName
            };

            _context.Roles.Add(role);
            _context.SaveChanges();
        }
    }
}
