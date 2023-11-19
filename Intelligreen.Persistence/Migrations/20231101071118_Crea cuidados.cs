using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intelligreen.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Creacuidados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CLasificacionCuidado",
                table: "Plantas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasificacionAgua",
                table: "Plantas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasificacionSol",
                table: "Plantas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cuidados",
                columns: table => new
                {
                    CuidadoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    PlantaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuidados", x => x.CuidadoId);
                    table.ForeignKey(
                        name: "FK_Cuidados_Plantas_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Plantas",
                        principalColumn: "PlantaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuidados_PlantaId",
                table: "Cuidados",
                column: "PlantaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuidados");

            migrationBuilder.DropColumn(
                name: "CLasificacionCuidado",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "ClasificacionAgua",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "ClasificacionSol",
                table: "Plantas");
        }
    }
}
