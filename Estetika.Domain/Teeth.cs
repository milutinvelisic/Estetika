using System;
using System.Collections.Generic;
using System.Text;

namespace Estetika.Domain
{
    public class Teeth : EntityBase 
    {

        public int Id { get; set; }

        public int ToothNumber { get; set; }

        public ICollection<JawJawSideTooth> JawJawSideTeeth { get; set; } = new HashSet<JawJawSideTooth>();

    }
}
