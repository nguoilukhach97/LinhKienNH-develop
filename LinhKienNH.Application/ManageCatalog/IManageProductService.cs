using LinhKienNH.Application.DTO;
using LinhKienNH.Application.ManageCatalog.DTOS;
using LinhKienNH.Application.ManageCatalog.DTOS.Manage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienNH.Application.ManageCatalog
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest productCreateRequest);
        Task<int> Update(ProductEditRequest productEditRequest);
        Task<int> Delete(int productId);
        Task AddViewCount(int idProduct);
        Task<List<ProductViewModel>> GetAll();
        Task<PagedViewModel<ProductViewModel>> GetAllPaging(GetProductPagingRequest paginRequest);
        
    }
}
