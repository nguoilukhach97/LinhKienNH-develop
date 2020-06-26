using LinhKien.Utilities.Exceptions;
using LinhKienNH.Application.DTO;
using LinhKienNH.Application.ManageCatalog.DTOS;
using LinhKienNH.Application.ManageCatalog.DTOS.Manage;
using LinhKienNH.Data.EF;
using LinhKienNH.Data.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienNH.Application.ManageCatalog.ManageProducts
{
    public class ManageProductService : IManageProductService
    {
        private readonly ShopDbContext _context;
        public ManageProductService(ShopDbContext context)
        {
            _context = context;
        }

        public async Task AddViewCount(int idProduct)
        {
            var product = await _context.Products.FindAsync(idProduct);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();

        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Name = request.Name,
                CatalogId=request.CatalogId,
                BrandId=request.BrandId,
                IdSize=request.IdSize,
                Description=request.Description,
                Details=request.Details,
                Price=request.Price,
                PromotionPrice = request.PromotionPrice,
                Image = request.Image,
                ImageThumb=request.ImageThumb,
                Quantity = request.Quantity,
                Warranty=request.Warranty,
                DateCreated=request.DateCreated,
                UserCreated=request.UserCreated,
                Status=request.Status

            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product==null)
            {
                throw new ShopException($"Cannot find product : { productId}");
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedViewModel<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ProductEditRequest productEditRequest)
        {
            throw new NotImplementedException();
        }

        Task<int> IManageProductService.Delete(int productId)
        {
            throw new NotImplementedException();
        }

        Task<List<ProductViewModel>> IManageProductService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<PagedViewModel<ProductViewModel>> IManageProductService.GetAllPaging(GetProductPagingRequest paginRequest)
        {
            throw new NotImplementedException();
        }
    }
}
