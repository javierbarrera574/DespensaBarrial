using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DespensaBarrial.BD.Migrations
{
    public partial class Prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaveProducto = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    NombreProducto = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DescripcionProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVencimientoProducto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrecioProducto = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumeroTelefono = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "Date", nullable: true),
                    DNI = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClasificacionCategoria = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    ProveedoresId = table.Column<int>(type: "int", nullable: true),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    ProductosId = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categorias_Productos_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Categorias_Proveedores_ProveedoresId",
                        column: x => x.ProveedoresId,
                        principalTable: "Proveedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_ProductosId",
                table: "Categorias",
                column: "ProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_ProveedoresId",
                table: "Categorias",
                column: "ProveedoresId");

            migrationBuilder.CreateIndex(
                name: "ProductoProveedor:1234",
                table: "Categorias",
                column: "ProductoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Producto: Dragon Ball Z",
                table: "Productos",
                column: "NombreProducto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Proveedor: 34902124",
                table: "Proveedores",
                column: "DNI",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
