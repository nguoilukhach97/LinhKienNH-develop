using LinhKienNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(p=>p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(p => p.UserName).IsRequired();
            builder.Property(p => p.PassWord).IsRequired();
            builder.Property(p => p.GroupId).IsRequired();
            builder.HasOne(p => p.UserGroups).WithMany(x => x.Users).HasForeignKey(p => p.GroupId);
        }
    }
}
