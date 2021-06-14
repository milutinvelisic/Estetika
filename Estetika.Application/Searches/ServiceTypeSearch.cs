using Estetika.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Searches
{
    public class ServiceTypeSearch : PagedSearch
    {
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
    }
}
