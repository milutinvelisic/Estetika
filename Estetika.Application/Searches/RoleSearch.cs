using Estetika.Application.DataTransfer;
using Estetika.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Searches
{
    public class RoleSearch : PagedSearch
    {
        public string RoleName { get; set; }
    }
}
