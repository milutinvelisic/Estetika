using Estetika.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Searches
{
    public class EKartonSearch : PagedSearch
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Service { get; set; }
        public string DentistFirstName { get; set; }
        public string DentistLastName { get; set; }
    }
}
