using System;
using System.Collections.Generic;
using System.Text;

namespace Estetika.Domain
{
    public class Jaw : EntityBase
    {

        public int Id { get; set; }

        public string JawName { get; set; }

        public ICollection<JawJawSideTooth> JawJawSideTeeth { get; set; } = new HashSet<JawJawSideTooth>();

    }

    public enum JawType
    {
        Upper,
        Lower
    }
}
