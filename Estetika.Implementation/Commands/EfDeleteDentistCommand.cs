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
    public class EfDeleteDentistCommand : IDeleteDentistCommand
    {
        private readonly EstetikaContext _context;

        public EfDeleteDentistCommand(EstetikaContext context)
        {
            _context = context;
        }

        public int Id => 5;

        public string Name => "Delete dentist using EF";

        public void Execute(int request)
        {
            var dentist = _context.Dentists.Find(request);

            if(dentist == null)
            {
                throw new EntityNotFoundException(request, typeof(Dentist));
            }

            dentist.IsDeleted = true;
            dentist.IsActive = false;
            dentist.DeletedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
