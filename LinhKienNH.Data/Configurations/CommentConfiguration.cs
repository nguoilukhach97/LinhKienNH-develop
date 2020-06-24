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
            builder.Property(p=>p.PhoneNumber).IsRequired().IsUnicode(false).HasMaxLength(12);
            builder.HasOne(x => x.Products).WithMany(x => x.Comments).HasForeignKey(p=>p.ProductId);

           
            builder.Property(p => p.Name).HasMaxLength(250);
            builder.Property(p => p.ContentComment).HasColumnType("ntext");

          
            builder.Property(x => x.Rating).IsRequired().HasDefaultValue(5);
            builder.Property(x => x.DateCreated).HasColumnType("datetime");
            builder.Property(x => x.Status).HasColumnType("bit").HasDefaultValueSql("1");
        }
    }
}
