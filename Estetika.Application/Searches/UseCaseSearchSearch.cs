using Estetika.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Searches
{
    public class UseCaseSearchSearch : PagedSearch
    {
        public string UseCaseName { get; set; }
        public string Actor { get; set; }
    }
}
