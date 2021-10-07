using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class warehouseidfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "WarehouseCellId",
                table: "Products",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WarehouseCellId",
                table: "Products",
                column: "WarehouseCellId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_WarehouseCells_WarehouseCellId",
                table: "Products",
                column: "WarehouseCellId",
                principalTable: "WarehouseCells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_WarehouseCells_WarehouseCellId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_WarehouseCellId",
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
        }
    }
}
