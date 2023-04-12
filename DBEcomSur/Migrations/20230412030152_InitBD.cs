using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBEcomSur.Migrations
{
    /// <inheritdoc />
    public partial class InitBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BDProductos",
                columns: table => new
                {
                    fiProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fcProducto = table.Column<int>(type: "int", nullable: false),
                    fdPrecio = table.Column<double>(type: "float", nullable: false),
                    fiCantidadProducto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BDProductos", x => x.fiProductoId);
                });

            migrationBuilder.CreateTable(
                name: "BDUsuarios",
                columns: table => new
                {
                    fiUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fcNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fcAmaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fcApaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fcCalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fcNumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fcColonia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fcFechaCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BDUsuarios", x => x.fiUsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "BDVentas",
                columns: table => new
                {
                    fiVentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fiUsuarioId = table.Column<int>(type: "int", nullable: false),
                    fiProductoId = table.Column<int>(type: "int", nullable: false),
                    cantidaCompr = table.Column<int>(type: "int", nullable: false),
                    fcFechaCompra = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BDVentas", x => x.fiVentaId);
                    table.ForeignKey(
                        name: "FK_BDVentas_BDProductos_fiProductoId",
                        column: x => x.fiProductoId,
                        principalTable: "BDProductos",
                        principalColumn: "fiProductoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BDVentas_BDUsuarios_fiUsuarioId",
                        column: x => x.fiUsuarioId,
                        principalTable: "BDUsuarios",
                        principalColumn: "fiUsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BDVentas_fiProductoId",
                table: "BDVentas",
                column: "fiProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_BDVentas_fiUsuarioId",
                table: "BDVentas",
                column: "fiUsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BDVentas");

            migrationBuilder.DropTable(
                name: "BDProductos");

            migrationBuilder.DropTable(
                name: "BDUsuarios");
        }
    }
}
