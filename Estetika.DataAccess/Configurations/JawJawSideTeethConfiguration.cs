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
    public class JawJawSideTeethConfiguration : IEntityTypeConfiguration<JawJawSideTooth>
    {
        public void Configure(EntityTypeBuilder<JawJawSideTooth> builder)
        {
            builder.HasMany(x => x.EKarton).WithOne(x => x.JawJawSideTooth).HasForeignKey(x => x.JawJawSideToothId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
