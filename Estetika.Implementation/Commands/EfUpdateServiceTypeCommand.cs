using Estetika.Application.Commands;
using Estetika.Application.DataTransfer;
using Estetika.Application.Exceptions;
using Estetika.DataAccess;
using Estetika.Domain;
using Estetika.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Commands
{
    public class EfUpdateServiceTypeCommand : IUpdateServiceTypeCommand
    {
        private readonly EstetikaContext _context;
        private readonly UpdateServiceTypeValidator validator;

        public EfUpdateServiceTypeCommand(EstetikaContext context, UpdateServiceTypeValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 18;

        public string Name => "Update serviceType using EF";

        public void Execute(ServiceTypeDto request)
        {
            var serviceType = _context.ServiceTypes.Find(request.Id);

            if (serviceType == null) throw new EntityNotFoundException(request.Id, typeof(ServiceType));

            if(request.ServiceName != null)
            {
                serviceType.ServiceName = request.ServiceName;
            }
            if(request.ServiceDescription != null)
            {
                serviceType.ServiceDescription = request.ServiceDescription;
            }
            if(request.ServicePrice != null)
            {
                serviceType.ServicePrice = request.ServicePrice;
            }

            _context.SaveChanges();
        }
    }
}
