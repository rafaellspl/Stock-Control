using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock_Control_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Domain.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder) 
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.ProductName).IsRequired();
            builder.Property(x => x.ProductBarCode).IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .IsRequired();

            #region [AcessControl]
            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.DeletedAt);
            #endregion
        }
    }
}
