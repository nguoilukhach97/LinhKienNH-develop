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
            builder.Property(x => x.Id).UseIdentityColumn();
                     

            builder.Property(x => x.Name).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Description).HasColumnType("ntext");
            builder.Property(x => x.Details).HasColumnType("ntext");
            builder.Property(x => x.Price).IsRequired().HasDefaultValueSql("0");
            builder.Property(x => x.PromotionPrice).HasDefaultValueSql("0");
            builder.Property(x => x.Quantity).IsRequired().HasDefaultValueSql("0");
            builder.Property(x => x.Warranty).HasDefaultValueSql("0");
            builder.Property(x => x.DateCreated).HasColumnType("datetime");
            builder.Property(x => x.DateModified).HasColumnType("datetime");


        }
    }
}
