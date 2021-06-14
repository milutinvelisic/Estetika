using Estetika.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Searches
{
    public class DentistSearch : PagedSearch
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
