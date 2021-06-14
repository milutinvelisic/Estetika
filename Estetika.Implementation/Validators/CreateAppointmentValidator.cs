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
    public class CreateAppointmentValidator : AbstractValidator<AppointmentDto>
    {
        private readonly EstetikaContext context;
        public CreateAppointmentValidator(EstetikaContext context)
        {
            this.context = context;

            RuleFor(x => x.FirstNameLastName).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Date).NotEmpty().Must(BeAValidDate);
            RuleFor(x => x.Time).NotEmpty().Must(BeAValidDate);
            RuleFor(x => x.Phone).NotEmpty();
            RuleFor(x => x.ServiceTypeId).NotEmpty().Must(ServiceTypeExists);
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }

        private bool ServiceTypeExists(int serviceTypeId)
        {
            return context.ServiceTypes.Any(x => x.Id == serviceTypeId);
        }
    }
}
