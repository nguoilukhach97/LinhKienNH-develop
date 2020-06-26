using LinhKienNH.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Application.ManageCatalog.DTOS.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { get; set; }
        public List<int> CategoryId { get; set; }
    }
}
