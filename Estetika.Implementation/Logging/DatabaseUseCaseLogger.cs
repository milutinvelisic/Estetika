using Estetika.Application;
using Estetika.DataAccess;
using Estetika.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Logging
{
    public class DatabaseUseCaseLogger : IUseCaseLogger
    {
        private readonly EstetikaContext _context;

        public DatabaseUseCaseLogger(EstetikaContext context) => _context = context;

        public void Log(IUseCase useCase, IApplicationActor actor, object useCaseData)
        {
            _context.UseCaseLog.Add(new UseCaseLog
            {
                Actor = actor.Identity,
                Data = JsonConvert.SerializeObject(useCaseData),
                Date = DateTime.UtcNow,
                UseCaseName = useCase.Name
            });

            _context.SaveChanges();
        }
    }
}
