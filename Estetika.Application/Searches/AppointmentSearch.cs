using Estetika.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Searches
{
    public class AppointmentSearch : PagedSearch
    {
        public string FirstNameLastName { get; set; }

        public string Service { get; set; }
    }
}
