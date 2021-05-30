using Estetika.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.DataAccess.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.Property(x => x.FirstNameLastName).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Time).IsRequired();
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
        }
    }
}
