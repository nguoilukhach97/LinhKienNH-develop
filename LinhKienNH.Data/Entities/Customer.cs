using LinhKienNH.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public Status Status { get; set; }

        public List<Order> Orders { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
