using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Entities
{
    public class UserGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }

        public List<User> Users { get; set; }
    }
}
