using Microsoft.EntityFrameworkCore.Migrations;

namespace LinhKienNH.Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "ntext",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
