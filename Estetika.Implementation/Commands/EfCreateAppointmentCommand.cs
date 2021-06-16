using Estetika.Application.Commands;
using Estetika.Application.DataTransfer;
using Estetika.Application.Email;
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
    public class EfCreateAppointmentCommand : ICreateAppointmentCommand
    {
        private readonly EstetikaContext _context;
        private readonly CreateAppointmentValidator validator;
        private readonly IEmailSender _sender;

        public EfCreateAppointmentCommand(EstetikaContext context, CreateAppointmentValidator validator, IEmailSender sender)
        {
            _context = context;
            this.validator = validator;
            this._sender = sender;
        }

        public int Id => 25;

        public string Name => "Create Appointment using EF";

        public void Execute(AppointmentDto request)
        {
            validator.ValidateAndThrow(request);

            var appointment = new Appointment
            {
                FirstNameLastName = request.FirstNameLastName,
                Email = request.Email,
                Date = request.Date,
                Time = request.Time,
                Phone = request.Phone,
                ServiceTypeId = request.ServiceTypeId
            };

            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            _sender.Send(new SendEmailDto
            {
                Content = $"<h1>Successfull Created  Appointment for user {request.FirstNameLastName} with date {request.Date}!</h1>",
                SendTo = request.Email,
                Subject = "Appointment"
            });
        }
    }
}
