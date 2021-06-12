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
    public class CreateDentistValidator : AbstractValidator<DentistDto>
    {
        public CreateDentistValidator(EstetikaContext context)
        {
            RuleFor(x => x.FirstName).NotEmpty()
                .MinimumLength(3).WithMessage("FirstName must be atleast 3 letters long.")
                .MaximumLength(30).WithMessage("FirstName must not be longer then 30 letters.");

            RuleFor(x => x.LastName).NotEmpty()
                .MinimumLength(3).WithMessage("LastName must be atleast 3 letters long.")
                .MaximumLength(30).WithMessage("LastName must not be longer then 30 letters.");
        }
    }
}
