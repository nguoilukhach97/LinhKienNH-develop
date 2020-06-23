using LinhKienNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(p=>p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p=>p.PhoneNumber).IsRequired();
        }
    }
}
