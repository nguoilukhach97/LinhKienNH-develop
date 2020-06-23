using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Entities
{
    public class UserRole
    {
        public int RoleId { get; set; }
        public int UserGroupId { get; set; }
        public Role Roles { get; set; }
        public UserGroup UserGroups { get; set; }
    }
}
