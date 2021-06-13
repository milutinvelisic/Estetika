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
    public class EfDeleteJawCommand : IDeleteJawCommand
    {
        private readonly EstetikaContext _context;

        public EfDeleteJawCommand(EstetikaContext context)
        {
            _context = context;
        }

        public int Id => 11;

        public string Name => "Delete jaw using EF";

        public void Execute(int request)
        {
            var jaw = _context.Jaws.Find(request);

            if (jaw == null) throw new EntityNotFoundException(request, typeof(Jaw));

            jaw.IsDeleted = true;
            jaw.IsActive = false;
            jaw.DeletedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
