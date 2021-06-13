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
    public class UpdateJawValidator : AbstractValidator<JawDto>
    {
        public UpdateJawValidator(EstetikaContext context)
        {
            RuleFor(x => x.JawName).NotEmpty()
                 .DependentRules(() =>
                 {
                     RuleFor(x => x.JawName).Must(jawName => !context.Jaws.Any(x => x.JawName == jawName)).WithMessage("JawName must be unique.");
                    //RuleFor(x => x.JawName).Matches(jawName => "^Upper$").WithMessage("JawName must be Upper.");
                    //RuleFor(x => x.JawName).Matches(jawName => "^Lower$").WithMessage("JawName must be Lower.");
                });
        }
    }
}
