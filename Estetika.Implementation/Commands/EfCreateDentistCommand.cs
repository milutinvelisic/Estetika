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
    public class EfCreateDentistCommand : ICreateDentistCommand
    {
        private readonly EstetikaContext _context;
        private readonly CreateDentistValidator validator;

        public EfCreateDentistCommand(EstetikaContext context, CreateDentistValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 4;

        public string Name => "Create dentist using EF!";

        public void Execute(DentistDto request)
        {
            validator.ValidateAndThrow(request);

            var dentist = new Dentist
            {
                FirstName = request.FirstName,
                LastName = request.LastName
            };

            _context.Dentists.Add(dentist);
            _context.SaveChanges();
        }
    }
}
