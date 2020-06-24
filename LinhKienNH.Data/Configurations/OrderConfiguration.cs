using LinhKienNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.OrderDate).HasColumnType("datetime");
            builder.Property(x=>x.CustomerId).IsRequired();
            builder.Property(x => x.Note).HasColumnType("ntext");
            builder.Property(x => x.Cancel).HasColumnType("ntext");
            builder.HasOne(p => p.Customers).WithMany(x => x.Orders).HasForeignKey(p=>p.CustomerId);

            builder.Property(x => x.Status).IsRequired().HasDefaultValueSql("1");
            
        }
    }
}
