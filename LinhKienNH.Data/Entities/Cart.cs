using LinhKienNH.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }

        public Customer Customers { get; set; }
    }
}
