using Estetika.Application.Commands;
using Estetika.Application.DataTransfer;
using Estetika.Application.Exceptions;
using Estetika.DataAccess;
using Estetika.Domain;
using Estetika.Implementation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Commands
{
    public class EfUpdateJawCommand : IUpdateJawCommand
    {
        private readonly EstetikaContext _context;
        private readonly UpdateJawValidator validator;

        public EfUpdateJawCommand(EstetikaContext context, UpdateJawValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 12;

        public string Name => "Update jaw using EF";

        public void Execute(JawDto request)
        {
            var jaw = _context.Jaws.Find(request.Id);

            if (jaw == null) throw new EntityNotFoundException(request.Id, typeof(Jaw));

            validator.ValidateAndThrow(request);

            jaw.JawName = request.JawName;

            _context.SaveChanges();
        }
    }
}
