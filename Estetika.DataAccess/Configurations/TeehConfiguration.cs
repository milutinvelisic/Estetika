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
    public class TeehConfiguration : IEntityTypeConfiguration<Teeth>
    {
        public void Configure(EntityTypeBuilder<Teeth> builder)
        {
            builder.Property(x => x.ToothNumber).IsRequired().HasMaxLength(1);
            builder.HasIndex(x => x.ToothNumber).IsUnique();

            builder.HasMany(x => x.JawJawSideTeeth).WithOne(x => x.Tooth).HasForeignKey(x => x.ToothId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
