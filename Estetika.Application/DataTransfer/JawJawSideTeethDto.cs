using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.DataTransfer
{
    public class JawJawSideTeethDto
    {
        public int Id { get; set; }
        public int JawId { get; set; }
        public int JawSideId { get; set; }
        public int ToothId { get; set; }
    }
}
