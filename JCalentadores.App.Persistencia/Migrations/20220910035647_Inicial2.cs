using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JCalentadores.App.Persistencia.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CitaServicio_Servicio_servicioIdid",
                table: "CitaServicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Servicio",
                table: "Servicio");

            migrationBuilder.RenameTable(
                name: "Servicio",
                newName: "Servicios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servicios",
                table: "Servicios",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CitaServicio_Servicios_servicioIdid",
                table: "CitaServicio",
                column: "servicioIdid",
                principalTable: "Servicios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CitaServicio_Servicios_servicioIdid",
                table: "CitaServicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Servicios",
                table: "Servicios");

            migrationBuilder.RenameTable(
                name: "Servicios",
                newName: "Servicio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servicio",
                table: "Servicio",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CitaServicio_Servicio_servicioIdid",
                table: "CitaServicio",
                column: "servicioIdid",
                principalTable: "Servicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
