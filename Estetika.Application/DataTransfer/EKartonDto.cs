using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.DataTransfer
{
    public class EKartonDto
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public int ServiceTypeId { get; set; }

        public int JawJawSideToothId { get; set; }

        public int UserId { get; set; }
    }
}
