using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Domain
{
    public class Dentist : EntityBase
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<EKarton> EKarton { get; set; } = new HashSet<EKarton>();
    }
}
