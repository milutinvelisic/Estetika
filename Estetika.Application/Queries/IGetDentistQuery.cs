using Estetika.Application.DataTransfer;
using Estetika.Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Queries
{
    public interface IGetDentistQuery : IQuery<DentistSearch, PagedResponse<DentistDto>>
    {
    }
}
