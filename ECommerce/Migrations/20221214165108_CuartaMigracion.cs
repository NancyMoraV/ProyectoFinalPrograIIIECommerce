using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Migrations
{
    /// <inheritdoc />
    public partial class CuartaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_carrito_CarritoId",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "CarritoId",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_carrito_ProductoId",
                table: "carrito",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_carrito_Productos_ProductoId",
                table: "carrito",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_carrito_CarritoId",
                table: "Productos",
                column: "CarritoId",
                principalTable: "carrito",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carrito_Productos_ProductoId",
                table: "carrito");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_carrito_CarritoId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_carrito_ProductoId",
                table: "carrito");

            migrationBuilder.AlterColumn<int>(
                name: "CarritoId",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_carrito_CarritoId",
                table: "Productos",
                column: "CarritoId",
                principalTable: "carrito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
