using LinhKienNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(p => p.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x => x.CustomerName).HasMaxLength(250);
            builder.Property(p => p.CustomerPhone).IsUnicode(false).IsRequired().HasMaxLength(250);
            builder.Property(x => x.CustomerEmail).HasMaxLength(250).IsUnicode(false);
            builder.Property(x => x.CustomerAddress).HasMaxLength(250);

            
        }
    }
}
