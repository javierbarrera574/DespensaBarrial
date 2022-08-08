using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DespensaBarrial.BD.Migrations
{
    public partial class Prueba2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClasificacionCategoria",
                table: "Categorias",
                newName: "NumeroDeCategoria");

            migrationBuilder.RenameIndex(
                name: "ProductoProveedor:1234",
                table: "Categorias",
                newName: "Categoria_Producto_Proveedor:1234");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroDeCategoria",
                table: "Categorias",
                newName: "ClasificacionCategoria");

            migrationBuilder.RenameIndex(
                name: "Categoria_Producto_Proveedor:1234",
                table: "Categorias",
                newName: "ProductoProveedor:1234");
        }
    }
}
