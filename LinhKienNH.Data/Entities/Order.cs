using LinhKienNH.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string Note { get; set; }
        public string Cancel { get; set; }
        public int UserCreated { get; set; }
        public int UserCancel { get; set; }
        public int Status { get; set; }

        public List<OrderItem> OrderItems { get; set; }
        public Customer Customers { get; set; }
    }
}
