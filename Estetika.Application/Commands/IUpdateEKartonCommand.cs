using Estetika.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Commands
{
    public interface IUpdateEKartonCommand : ICommand<EkartonDto>
    {
    }
}
