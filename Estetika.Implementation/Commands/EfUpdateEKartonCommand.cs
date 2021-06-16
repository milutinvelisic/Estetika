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
    public class EfUpdateEKartonCommand : IUpdateEKartonCommand
    {
        private readonly EstetikaContext _context;
        private readonly UpdateEKartonValidator validator;

        public EfUpdateEKartonCommand(EstetikaContext context, UpdateEKartonValidator validator)
        {
            _context = context;
            this.validator = validator;
        }
        public int Id => 41;

        public string Name => "Update ekarton using EF";

        public void Execute(EkartonDto request)
        {
            var ekarton = _context.EKartons.Find(request.Id);

            if (ekarton == null) throw new EntityNotFoundException(request.Id, typeof(EKarton));

            validator.ValidateAndThrow(request);

            ekarton.Date = request.Date;
            ekarton.ServiceTypeId = request.ServiceTypeId;
            ekarton.DentistId = request.DentistId;
            ekarton.UserId = request.UserId;
            ekarton.JawJawSideToothId = request.JawJawSideToothId;
            ekarton.Price = request.Price;

            _context.SaveChanges();
        }
    }
}
