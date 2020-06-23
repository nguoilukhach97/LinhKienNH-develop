using LinhKienNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles");
            builder.HasKey(x=>new { x.RoleId,x.UserGroupId});
            builder.HasOne(p => p.Roles).WithMany(x => x.UserRoles).HasForeignKey(p=>p.RoleId);
            builder.HasOne(p => p.UserGroups).WithMany(x => x.UserRoles).HasForeignKey(p=>p.UserGroupId);
        }
    }
}
