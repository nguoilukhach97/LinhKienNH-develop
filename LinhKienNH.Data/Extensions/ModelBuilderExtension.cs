using LinhKienNH.Data.EF.Entities;
using LinhKienNH.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LinhKienNH.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id=1,Name="Giày nữ",Image="",SortOder=1,Status=true});
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { CategoryId=1,ProductId=1});
            modelBuilder.Entity<Brand>().HasData(
                new Brand() { Id=1 ,Name="Adidas",Image="", Status=true});
            modelBuilder.Entity<Size>().HasData(
                new Size() {Id=1, SizeName=21,Description="size 21",Status=true });
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id=1,
                    BrandId = 2,
                    CatalogId = 2,
                    DateCreated = DateTime.Now,
                    Description = "không nên",
                    Details = "chi tiết",
                    IdSize = 2,
                    Image = "",
                    Name = "quả giày bá đạo",
                    Price = 1200,
                    Quantity = 12,
                    Status = true,
                    Warranty = 12,
                    UserCreated = 1
                }
                );
        }
    }
}
