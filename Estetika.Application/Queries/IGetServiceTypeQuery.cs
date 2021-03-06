using Estetika.Application.DataTransfer;
using Estetika.Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Queries
{
    public interface IGetServiceTypeQuery : IQuery<ServiceTypeSearch, PagedResponse<ServiceTypeDto>>
    {
    }
}
