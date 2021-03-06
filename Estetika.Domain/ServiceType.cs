using System;
using System.Collections.Generic;
using System.Text;

namespace Estetika.Domain
{
    public class ServiceType : EntityBase
    {
        public int Id { get; set; }

        public string ServiceName { get; set; }

        public string ServiceDescription { get; set; }

        public decimal ServicePrice { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();

        public virtual ICollection<EKarton> EKartons { get; set; } = new HashSet<EKarton>();

    }
}
