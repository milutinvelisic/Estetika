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
    public class JawConfiguration : IEntityTypeConfiguration<Jaw>
    {
        public void Configure(EntityTypeBuilder<Jaw> builder)
        {
            builder.Property(x => x.JawName).IsRequired().HasMaxLength(10);
            builder.HasIndex(x => x.JawName).IsUnique();

            builder.HasMany(x => x.JawJawSideTeeth).WithOne(x => x.Jaw).HasForeignKey(x => x.JawId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
