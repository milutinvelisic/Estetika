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
    public class EfUpdateUserCommand : IUpdateUserCommand
    {
        private readonly EstetikaContext _context;
        private readonly UpdateUserValidator validator;

        public EfUpdateUserCommand(EstetikaContext context, UpdateUserValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 32;

        public string Name => "Update user using EF";

        public void Execute(UserDto request)
        {
            var user = _context.Users.Find(request.Id);

            if (user == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(User));
            }

            validator.ValidateAndThrow(request);

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Password = request.Password;
            user.Phone = request.Phone;
            user.RoleId = request.RoleId;

            _context.SaveChanges();
        }
    }
}
