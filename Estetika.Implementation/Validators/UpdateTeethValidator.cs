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
    public class UpdateTeethValidator : AbstractValidator<TeethDto>
    {
        public UpdateTeethValidator(EstetikaContext context)
        {
            RuleFor(x => x.ToothNumber).NotEmpty().WithMessage("ToothNumber must not be empty and must not be 0.")
                .Must(toothNumber => toothNumber < 9).WithMessage("ToothNumber must not be greater then 8.")
                .Must(toothNumber => toothNumber > 0).WithMessage("ToothNumber must not be negative.")
                .Must(toothNumber => !context.Teeths.Any(x => x.ToothNumber == toothNumber)).WithMessage("ToothNumber must be unique.");
        }
    }
}
