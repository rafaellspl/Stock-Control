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
    public class ProductCategoryMap : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder) 
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CategoryName).IsRequired();
            builder.HasMany(x => x.SubCategories).WithOne(x => x.ParentCategory).HasForeignKey(x => x.ParentCategoryId);
            builder.Ignore(x => x.ProductList);

            #region [AcessControl]
            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.DeletedAt);
            #endregion
        }
    }
}
