using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.DataTransfer
{
    public class AppointmentDto
    {
        public int Id { get; set; }

        public string FirstNameLastName { get; set; }

        public string Email { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public string Phone { get; set; }

        public int ServiceTypeId { get; set; }
    }
}
