using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class warehousefixed100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_WarehouseCells_WarehouseCellId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseCellId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_WarehouseCells_WarehouseCellId",
                table: "Products",
                column: "WarehouseCellId",
                principalTable: "WarehouseCells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_WarehouseCells_WarehouseCellId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseCellId",
                table: "Products",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_WarehouseCells_WarehouseCellId",
                table: "Products",
                column: "WarehouseCellId",
                principalTable: "WarehouseCells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
