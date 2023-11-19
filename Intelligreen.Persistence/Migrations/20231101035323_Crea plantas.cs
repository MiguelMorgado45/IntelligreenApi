using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intelligreen.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Creaplantas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plantas",
                columns: table => new
                {
                    PlantaId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    NombreCientifico = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    HumedadTierra = table.Column<float>(type: "real", nullable: false),
                    HumedadAmbiente = table.Column<float>(type: "real", nullable: false),
                    TemperaturaAmbiente = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantas", x => x.PlantaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plantas");
        }
    }
}
