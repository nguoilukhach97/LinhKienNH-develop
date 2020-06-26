using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Application.ManageCatalog.DTOS.Manage
{
    public class ProductEditRequest
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int CatalogId { get; set; }
        public int BrandId { get; set; }
        public int IdSize { get; set; }
        public string Description { get; set; }

        public string Details { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public string Image { get; set; }
        public string ImageThumb { get; set; }
        public int Quantity { get; set; }
        public int Warranty { get; set; }
        
        
        public bool Status { get; set; }
        
    }
}
