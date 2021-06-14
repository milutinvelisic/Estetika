using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Queries
{
    public class PagedSearch
    {
        public int PerPage { get; } = 10;
        public int Page { get; } = 1;
    }
}
