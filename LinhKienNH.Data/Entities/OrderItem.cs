﻿using LinhKienNH.Data.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Entities
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Product Products { get; set; }
        public Order Orders { get; set; }
    }
}
