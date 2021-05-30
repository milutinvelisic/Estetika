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
    public class ServiceTypeConfiguration : IEntityTypeConfiguration<ServiceType>
    {
        public void Configure(EntityTypeBuilder<ServiceType> builder)
        {
            builder.HasIndex(x => x.ServiceName).IsUnique();
            builder.Property(x => x.ServiceName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.ServicePrice).IsRequired();

            builder.HasMany(x => x.Appointments).WithOne(x => x.ServiceTypes).HasForeignKey(x => x.ServiceTypeId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.EKartons).WithOne(x => x.ServiceTypes).HasForeignKey(x => x.ServiceTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
