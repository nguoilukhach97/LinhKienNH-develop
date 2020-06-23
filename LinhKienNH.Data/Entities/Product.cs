using LinhKienNH.Data.Entities;
using LinhKienNH.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.EF.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CatalogId { get; set; }
        public int BrandId { get; set; }
        public int Description { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public string Image { get; set; }
        public string ImageThumb { get; set; }
        public int Quantity { get; set; }
        public int Warranty { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserModified { get; set; }
        public Status Status { get; set; }
        public int ViewCount { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
