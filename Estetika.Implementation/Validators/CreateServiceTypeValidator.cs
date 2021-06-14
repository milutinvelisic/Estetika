using Estetika.Application.DataTransfer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Validators
{
    public class CreateServiceTypeValidator : AbstractValidator<ServiceTypeDto>
    {
        public CreateServiceTypeValidator()
        {
            RuleFor(x => x.ServiceName).NotEmpty();
            RuleFor(x => x.ServiceDescription).NotEmpty();
            RuleFor(x => x.ServicePrice).NotEmpty();
        }
    }
}
