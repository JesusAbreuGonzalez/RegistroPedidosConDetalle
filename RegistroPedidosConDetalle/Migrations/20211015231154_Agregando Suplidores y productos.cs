using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroPedidosConDetalle.Migrations
{
    public partial class AgregandoSuplidoresyproductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Inventario" },
                values: new object[] { 1, 80f, "Cartón de jugo de naranja, 1 litro", 110f });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Inventario" },
                values: new object[] { 2, 50f, "Cartón de leche Listamilk, 1 litro", 85f });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Inventario" },
                values: new object[] { 3, 700f, "Pizza Grande Suprema de Pollo", 1225f });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorId", "Nombres" },
                values: new object[] { 1, "Pizza Hut" });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorId", "Nombres" },
                values: new object[] { 2, "C&H Technology" });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorId", "Nombres" },
                values: new object[] { 3, "Rica" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suplidores",
                keyColumn: "SuplidorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suplidores",
                keyColumn: "SuplidorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suplidores",
                keyColumn: "SuplidorId",
                keyValue: 3);
        }
    }
}
