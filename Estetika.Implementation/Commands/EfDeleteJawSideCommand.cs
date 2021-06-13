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
    public class EfDeleteJawSideCommand : IDeleteJawSideCommand
    {
        private readonly EstetikaContext _context;

        public EfDeleteJawSideCommand(EstetikaContext context)
        {
            _context = context;
        }

        public int Id => 14;

        public string Name => "Delete jawSide using EF";

        public void Execute(int request)
        {
            var jawSide = _context.JawSides.Find(request);

            if (jawSide == null) throw new EntityNotFoundException(request, typeof(JawSide));

            jawSide.IsDeleted = true;
            jawSide.IsActive = false;
            jawSide.DeletedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
