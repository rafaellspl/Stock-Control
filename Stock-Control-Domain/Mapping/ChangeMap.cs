using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock_Control_Domain.Entities.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Domain.Mapping
{
    public class ChangeMap : IEntityTypeConfiguration<Change>
    {
        public void Configure(EntityTypeBuilder<Change> builder)
        {
            builder.ToTable("LOG_modificacoes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.RelationalId).IsRequired();

            builder.Property(x => x.ChangeString).IsRequired();
            builder.Property(x => x.ModifiedAt).IsRequired();

            builder.HasOne(x => x.User)
                   .WithMany();
        }
    }
}
