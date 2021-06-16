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
    public class EfCreateEKartonCommand : ICreateEKartonCommand
    {
        private readonly EstetikaContext _context;
        private readonly CreateEKartonValidator validator;

        public EfCreateEKartonCommand(EstetikaContext context, CreateEKartonValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 40;

        public string Name => "Create Ekarton using EF";

        public void Execute(EkartonDto request)
        {
            validator.ValidateAndThrow(request);

            var ekarton = new EKarton
            {
                Date = request.Date,
                ServiceTypeId = request.ServiceTypeId,
                Price = request.Price,
                JawJawSideToothId = request.JawJawSideToothId,
                UserId = request.UserId,
                DentistId = request.DentistId,
            };

            _context.EKartons.Add(ekarton);
            _context.SaveChanges();
        }
    }
}
