using LinhKienNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(x=> new { x.CategoryId,x.ProductId});
            builder.ToTable("ProductInCategory");
            builder.HasOne(x => x.Product).WithMany(p => p.ProductInCategories)
                .HasForeignKey(p => p.ProductId);

            builder.HasOne(x => x.Category).WithMany(p => p.ProductInCategories)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
