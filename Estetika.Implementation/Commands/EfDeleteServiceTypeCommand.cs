using Estetika.Application.Commands;
using Estetika.Application.Exceptions;
using Estetika.DataAccess;
using Estetika.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Commands
{
    public class EfDeleteServiceTypeCommand : IDeleteServiceTypeCommand
    {
        private readonly EstetikaContext _context;

        public EfDeleteServiceTypeCommand(EstetikaContext context)
        {
            _context = context;
        }

        public int Id => 17;

        public string Name => "Delete serviceType using EF";

        public void Execute(int request)
        {
            var serviceType = _context.ServiceTypes.Find(request);

            if (serviceType == null) throw new EntityNotFoundException(request, typeof(ServiceType));

            serviceType.IsDeleted = true;
            serviceType.IsActive = false;
            serviceType.DeletedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
