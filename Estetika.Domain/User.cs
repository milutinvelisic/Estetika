using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Domain
{
    public class User : EntityBase
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }

        public virtual ICollection<EKarton> EKartons { get; set; } = new HashSet<EKarton>();
        public virtual ICollection<UserUseCases> UserUseCases { get; set; }
    }
}
