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
    public class EfCreateJawJawSideTeethCommand : ICreateJawJawSideTeethCommand
    {
        private readonly EstetikaContext _context;
        private readonly CreateJawJawSideTeethValidator validator;

        public EfCreateJawJawSideTeethCommand(EstetikaContext context, CreateJawJawSideTeethValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 24;

        public string Name => "Create jawJawSideTeeth using EF";

        public void Execute(JawJawSideTeethDto request)
        {
            validator.ValidateAndThrow(request);

            var jawJawSideTeeth = new JawJawSideTooth
            {
                JawId = request.JawId,
                JawSideId = request.JawSideId,
                ToothId = request.ToothId
            };

            _context.JawJawSideTeeth.Add(jawJawSideTeeth);
            _context.SaveChanges();
        }
    }
}
