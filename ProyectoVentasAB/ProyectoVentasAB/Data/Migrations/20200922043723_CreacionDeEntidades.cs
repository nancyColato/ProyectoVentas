using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoVentasAB.Data.Migrations
{
    public partial class CreacionDeEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Tiendas",
                columns: table => new
                {
                    IdTienda = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTienda = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: true),
                    Encargado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiendas", x => x.IdTienda);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(nullable: false),
                    FechaVencimiento = table.Column<DateTime>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    IdCategoria = table.Column<int>(nullable: false),
                    CategoriasIdCategoria = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriasIdCategoria",
                        column: x => x.CategoriasIdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    IdVenta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVenta = table.Column<DateTime>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<float>(nullable: false),
                    SubTotal = table.Column<float>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    IdProducto = table.Column<int>(nullable: false),
                    ProductosIdProducto = table.Column<int>(nullable: true),
                    IdTienda = table.Column<int>(nullable: false),
                    TiendasIdTienda = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK_Ventas_Productos_ProductosIdProducto",
                        column: x => x.ProductosIdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Tiendas_TiendasIdTienda",
                        column: x => x.TiendasIdTienda,
                        principalTable: "Tiendas",
                        principalColumn: "IdTienda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriasIdCategoria",
                table: "Productos",
                column: "CategoriasIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ProductosIdProducto",
                table: "Ventas",
                column: "ProductosIdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_TiendasIdTienda",
                table: "Ventas",
                column: "TiendasIdTienda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Tiendas");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
