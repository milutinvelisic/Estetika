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
    public class EfUpdateDentistCommand : IUpdateDentistCommand
    {
        private readonly EstetikaContext _context;
        private readonly UpdateDentistValidator validator;

        public EfUpdateDentistCommand(EstetikaContext context, UpdateDentistValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 6;

        public string Name => "Update dentist using EF";

        public void Execute(DentistDto request)
        {
            var dentist = _context.Dentists.Find(request.Id);

            if(dentist == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Dentist));
            }

            validator.ValidateAndThrow(request);

            if(request.FirstName != null)
            {
                dentist.FirstName = request.FirstName;
            }
            if(request.LastName != null)
            {
                dentist.LastName = request.LastName;
            }

            _context.SaveChanges();
        }
    }
}
