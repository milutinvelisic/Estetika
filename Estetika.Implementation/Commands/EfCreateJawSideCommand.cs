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
    public class EfCreateJawSideCommand : ICreateJawSideCommand
    {
        private readonly EstetikaContext _context;
        private readonly CreateJawSideValidator validator;

        public EfCreateJawSideCommand(EstetikaContext context, CreateJawSideValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 13;

        public string Name => "Create jawSide using EF";

        public void Execute(JawSideDto request)
        {
            validator.ValidateAndThrow(request);

            var jawSide = new JawSide
            {
                JawSideName = request.JawSideName
            };

            _context.JawSides.Add(jawSide);
            _context.SaveChanges();
        }
    }
}
