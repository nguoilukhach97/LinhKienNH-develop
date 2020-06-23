using LinhKienNH.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Rating { get; set; }
        public string ContentComment { get; set; }
        public DateTime DateCreated { get; set; }
        public Status Status { get; set; }
    }
}
