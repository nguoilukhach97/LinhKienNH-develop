﻿using LinhKienNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdCustomer).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.ProductId).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Quantity).HasDefaultValueSql("0");
            builder.HasOne(x => x.Customers).WithMany(x => x.Carts).HasForeignKey(p => p.IdCustomer);

            builder.Property(x => x.Status).HasDefaultValueSql("1");
        }
    }
}
