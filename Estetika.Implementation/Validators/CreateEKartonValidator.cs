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
    public class CreateEKartonValidator : AbstractValidator<EkartonDto>
    {
        public CreateEKartonValidator(EstetikaContext context)
        {
            RuleFor(x => x.Date).NotEmpty().Must(x => x.Date >= DateTime.Now).WithMessage("Date must be from tommorow!");
            RuleFor(x => x.Price).NotEmpty();
            RuleFor(x => x.JawJawSideToothId).NotEmpty().Must((jawjawsidetooth => context.JawJawSideTeeth.Any(g => g.Id== jawjawsidetooth))).WithMessage("Tooth doesnt exists!");
            RuleFor(x => x.ServiceTypeId).NotEmpty().Must((servicetypeid => context.ServiceTypes.Any(g => g.Id == servicetypeid))).WithMessage("Service doesnt exists!");
            RuleFor(x => x.UserId).NotEmpty().Must((user => context.Users.Any(g => g.Id == user))).WithMessage("Service doesnt exists!");
            RuleFor(x => x.DentistId).NotEmpty().Must((dentist => context.Dentists.Any(g => g.Id == dentist))).WithMessage("Service doesnt exists!");
        }
    }
}
