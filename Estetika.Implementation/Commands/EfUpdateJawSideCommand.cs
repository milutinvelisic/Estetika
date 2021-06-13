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
    public class EfUpdateJawSideCommand : IUpdateJawSideCommand
    {
        private readonly EstetikaContext _context;
        private readonly UpdateJawSideValidator validator;

        public EfUpdateJawSideCommand(EstetikaContext context, UpdateJawSideValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 15;

        public string Name => "Update jawSide using EF";

        public void Execute(JawSideDto request)
        {
            var jawSide = _context.JawSides.Find(request.Id);

            if (jawSide == null) throw new EntityNotFoundException(request.Id, typeof(JawSide));

            jawSide.JawSideName = request.JawSideName;

            _context.SaveChanges();
        }
    }
}
