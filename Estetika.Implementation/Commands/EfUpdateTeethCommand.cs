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
    public class EfUpdateTeethCommand : IUpdateTeethCommand
    {
        private readonly EstetikaContext _context;
        private readonly UpdateTeethValidator validator;

        public EfUpdateTeethCommand(EstetikaContext context, UpdateTeethValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 9;

        public string Name => "Update tooth using EF";

        public void Execute(TeethDto request)
        {
            var tooth = _context.Teeths.Find(request.Id);

            if(tooth == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Teeth));
            }

            validator.ValidateAndThrow(request);

            tooth.ToothNumber = request.ToothNumber;

            _context.SaveChanges();

        }
    }
}
