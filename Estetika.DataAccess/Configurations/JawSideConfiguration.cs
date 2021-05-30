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
    public class JawSideConfiguration : IEntityTypeConfiguration<JawSide>
    {
        public void Configure(EntityTypeBuilder<JawSide> builder)
        {
            builder.Property(x => x.JawSideName).IsRequired().HasMaxLength(10);
            builder.HasIndex(x => x.JawSideName).IsUnique();

            builder.HasMany(x => x.JawJawSideTeeth).WithOne(x => x.JawSide).HasForeignKey(x => x.JawSideId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
