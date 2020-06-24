using LinhKienNH.Data.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Entities
{
    public class Size
    {
        public int Id { get; set; }
        public int SizeName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public List<Product> Products { get; set; }
    }
}
