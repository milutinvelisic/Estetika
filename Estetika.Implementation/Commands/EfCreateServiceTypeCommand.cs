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
    public class EfCreateServiceTypeCommand : ICreateServiceTypeCommand
    {
        private readonly EstetikaContext _context;
        private readonly CreateServiceTypeValidator validator;

        public EfCreateServiceTypeCommand(EstetikaContext context, CreateServiceTypeValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 16;

        public string Name => "Create serviceType using EF";

        public void Execute(ServiceTypeDto request)
        {
            validator.ValidateAndThrow(request);

            var serviceType = new ServiceType
            {
                ServiceName = request.ServiceName,
                ServiceDescription = request.ServiceDescription,
                ServicePrice = request.ServicePrice
            };

            _context.ServiceTypes.Add(serviceType);
            _context.SaveChanges();
        }
    }
}
