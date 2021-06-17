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
    public class EfDeleteEKartonCommand : IDeleteEKartonCommand
    {

        private readonly EstetikaContext _context;

        public EfDeleteEKartonCommand(EstetikaContext context)
        {
            _context = context;
        }
        public int Id => 42;

        public string Name => "Delete EKarton using EF";

        public void Execute(int request)
        {
            var ekarton = _context.EKartons.Find(request);

            if (ekarton == null)
            {
                throw new EntityNotFoundException(request, typeof(EKarton));
            }

            ekarton.IsDeleted = true;
            ekarton.IsActive = false;
            ekarton.DeletedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
