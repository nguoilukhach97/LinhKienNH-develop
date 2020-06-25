using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LinhKienNH.Data.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "UserModified",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Products",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserModified",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Products",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Image", "Name", "Status" },
                values: new object[] { 1, "", "Adidas", true });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name", "ParentId", "SortOder", "Status" },
                values: new object[] { 1, "", "Giày nữ", 0, 1, true });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "Description", "SizeName", "Status" },
                values: new object[] { 1, "size 21", 21, true });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CatalogId", "DateCreated", "DateModified", "Description", "Details", "IdSize", "Image", "ImageThumb", "Name", "Price", "Quantity", "Status", "UserCreated", "UserModified", "ViewCount", "Warranty" },
                values: new object[] { 1, 1, 1, new DateTime(2020, 6, 25, 14, 6, 47, 134, DateTimeKind.Local).AddTicks(8974), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "không nên", "chi tiết", 1, "", null, "quả giày bá đạo", 1200m, 12, true, 1, 0, 0, 12 });

            migrationBuilder.InsertData(
                table: "ProductInCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });
        }
    }
}
