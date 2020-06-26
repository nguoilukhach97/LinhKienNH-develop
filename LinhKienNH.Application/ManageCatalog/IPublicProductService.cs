using LinhKienNH.Application.DTO;
using LinhKienNH.Application.ManageCatalog.DTOS;

using LinhKienNH.Application.ManageCatalog.DTOS.Public;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Application.ManageCatalog
{
    public interface IPublicProductService<T>
    {
        PagedViewModel<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
