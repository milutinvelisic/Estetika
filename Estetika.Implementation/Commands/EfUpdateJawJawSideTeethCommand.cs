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
    public class EfUpdateJawJawSideTeethCommand : IUpdateJawJawSideTeethCommand
    {
        private readonly EstetikaContext _context;
        private readonly UpdateJawJawSideTeethValidator validator;

        public EfUpdateJawJawSideTeethCommand(EstetikaContext context, UpdateJawJawSideTeethValidator validator)
        {
            this._context = context;
            this.validator = validator;
        }

        public int Id => 26;

        public string Name => "Update JawJawSideTeeth using EF";

        public void Execute(JawJawSideTeethDto request)
        {
            var jawJawSideTeeth = _context.JawJawSideTeeth.Find(request.Id);

            if (jawJawSideTeeth == null) throw new EntityNotFoundException(request.Id, typeof(JawJawSideTooth));

            validator.ValidateAndThrow(request);

            jawJawSideTeeth.JawId = request.JawId;
            jawJawSideTeeth.JawSideId = request.JawSideId;
            jawJawSideTeeth.ToothId = request.ToothId;

            _context.SaveChanges();
        }
    }
}
