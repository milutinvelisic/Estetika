using Estetika.Application.DataTransfer;
using Estetika.Application.Exceptions;
using Estetika.Application.Queries;
using Estetika.DataAccess;
using Estetika.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Queries
{
    public class EfGetOneServiceTypeQuery : IGetOneServiceTypeQuery
    {
        private readonly EstetikaContext _context;

        public EfGetOneServiceTypeQuery(EstetikaContext context)
        {
            _context = context;
        }

        public int Id => 21;

        public string Name => "Get one serviceType using EF";

        public ServiceTypeDto Execute(int search)
        {
            var serviceType = _context.ServiceTypes.Find(search);

            if (serviceType == null) throw new EntityNotFoundException(search, typeof(ServiceType));

            return new ServiceTypeDto
            {
                Id = search,
                ServiceName = serviceType.ServiceName,
                ServiceDescription = serviceType.ServiceDescription,
                ServicePrice = serviceType.ServicePrice
            };
        }
    }
}
