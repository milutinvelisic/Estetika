using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.DataTransfer
{
    public class JawDto
    {
        public int Id { get; set; }

        public string JawName { get; set; }

        public JawType JawType { get; set; }
    }

    public enum JawType {
        Upper,
        Lower
    }
}
