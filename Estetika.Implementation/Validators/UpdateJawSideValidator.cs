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
    public class UpdateJawSideValidator : AbstractValidator<JawSideDto>
    {
        public UpdateJawSideValidator(EstetikaContext context)
        {
            RuleFor(x => x.JawSideName).NotEmpty()
                .DependentRules(() =>
                {
                    RuleFor(x => x.JawSideName).Must(jawName => !context.JawSides.Any(x => x.JawSideName == jawName))
                    .WithMessage("JawSideName must be unique.");
                });
        }
    }
}
