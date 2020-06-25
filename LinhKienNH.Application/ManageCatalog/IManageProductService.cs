using LinhKienNH.Application.ManageCatalog.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Application.ManageCatalog
{
    public interface IManageProductService
    {
        int Create(ProductCreateRequest productCreateRequest);
        int Update(ProductEditRequest productEditRequest);
        int Delete(int productId);

        List<ProductViewModel> GetAll();
        List<ProductViewModel> GetAllPaging(string keyWork, int pageIndex, int pageSize);
        List<produc>
    }
}
