using LinhKienNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Configurations
{
    public class OrderItemConfigurationn : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(p => new { p.OrderId,p.ProductId});
            builder.Property(x=>x.Quantity).IsRequired();
            builder.HasOne(x => x.Products).WithMany(p => p.OrderItems).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x => x.Orders).WithMany(p => p.OrderItems).HasForeignKey(x=>x.OrderId);
        }
    }
}
