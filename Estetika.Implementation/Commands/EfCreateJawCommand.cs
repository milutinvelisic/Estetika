using Estetika.Application.Commands;
using Estetika.Application.DataTransfer;
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
    public class EfCreateJawCommand : ICreateJawCommand
    {
        private readonly EstetikaContext _context;
        private readonly CreateJawValidator validator;

        public EfCreateJawCommand(EstetikaContext context, CreateJawValidator validator = null)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 10;

        public string Name => "Create jaw using EF";

        public void Execute(JawDto request)
        {
            validator.ValidateAndThrow(request);

            var jaw = new Jaw
            {
                JawName = request.JawName
            };

            _context.Jaws.Add(jaw);
            _context.SaveChanges();
        }
    }
}
