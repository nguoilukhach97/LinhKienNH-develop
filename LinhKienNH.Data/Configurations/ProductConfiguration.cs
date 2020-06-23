using LinhKienNH.Data.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.PromotionPrice).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.PromotionPrice).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.UserCreated).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Quantity).IsRequired().HasDefaultValue(0);
        }
    }
}
