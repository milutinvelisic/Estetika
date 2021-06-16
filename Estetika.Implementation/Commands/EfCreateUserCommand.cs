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
    public class EfCreateUserCommand : ICreateUserCommand
    {
        private readonly EstetikaContext _context;
        private readonly CreateUsertValidator validator;

        public EfCreateUserCommand(EstetikaContext context, CreateUsertValidator validator)
        {
            _context = context;
            this.validator = validator;
        }

        public int Id => 31;

        public string Name => "Create user using EF";

        public void Execute(UserDto request)
        {

            validator.ValidateAndThrow(request);

            var user = new User
            {
               FirstName = request.FirstName,
               LastName = request.LastName,
               Email = request.Email,
               Password = request.Password,
               Phone = request.Phone,
               RoleId = 2
            };

            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
