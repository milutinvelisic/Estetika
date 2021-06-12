using Estetika.Application.DataTransfer;
using Estetika.DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Validators
{
    public class UpdateRoleValidator : AbstractValidator<RoleDto>
    {
        public UpdateRoleValidator(EstetikaContext context)
        {
            RuleFor(x => x.RoleName).NotEmpty().Must(name => !context.Roles.Any(g => g.RoleName == name)).WithMessage("Name must be unique!");
        }
    }
}
