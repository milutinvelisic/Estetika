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
    public class EfCreateTeethCommand : ICreateTeethCommand
    {
        private readonly EstetikaContext _context;
        private readonly CreateTeethValidator validator;

        public EfCreateTeethCommand(EstetikaContext context, CreateTeethValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 7;

        public string Name => "Create tooth using EF";

        public void Execute(TeethDto request)
        {
            validator.ValidateAndThrow(request);

            var tooth = new Teeth
            {
                ToothNumber = request.ToothNumber
            };

            _context.Teeths.Add(tooth);
            _context.SaveChanges();            
        }
    }
}
