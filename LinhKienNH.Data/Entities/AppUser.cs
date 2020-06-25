using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Entities
{
    public class AppUser: IdentityUser<Guid>
    {
        public string Firtsname { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }

    }
}
