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
    public class EfDeleteTeethCommand : IDeleteTeethCommand
    {
        private readonly EstetikaContext _context;

        public EfDeleteTeethCommand(EstetikaContext context)
        {
            _context = context;
        }

        public int Id => 8;

        public string Name => "Delete tooth using EF";

        public void Execute(int request)
        {
            var tooth = _context.Teeths.Find(request);

            if(tooth == null)
            {
                throw new EntityNotFoundException(request, typeof(Teeth));
            }

            tooth.IsDeleted = true;
            tooth.IsActive = false;
            tooth.DeletedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
