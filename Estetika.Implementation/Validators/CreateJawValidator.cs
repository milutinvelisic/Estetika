using Estetika.Application.DataTransfer;
using Estetika.DataAccess;
using Estetika.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Validators
{
    public class CreateJawValidator : AbstractValidator<JawDto>
    {
        public CreateJawValidator(EstetikaContext context)
        {
            RuleFor(x => x.JawName).NotEmpty()
                .DependentRules(() =>
                {
                    RuleFor(x => x.JawName).Must(jawName => !context.Jaws.Any(x => x.JawName == jawName)).WithMessage("JawName must be unique.");
                });
        }
    }
}
