using Estetika.Application.DataTransfer;
using Estetika.Application.Searches;
using Estetika.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Queries
{
    public interface IGetUseCaseLogQuery : IQuery<UseCaseSearchSearch, PagedResponse<UseCaseLogDto>>
    {
    }
}
