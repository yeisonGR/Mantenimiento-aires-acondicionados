using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JCalentadores.App.Persistencia.Migrations
{
    public partial class Inicial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Usuario_UsuarioIdid",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_CitaServicio_Cita_citaIdid",
                table: "CitaServicio");

            migrationBuilder.DropIndex(
                name: "IX_CitaServicio_citaIdid",
                table: "CitaServicio");

            migrationBuilder.DropIndex(
                name: "IX_Cita_UsuarioIdid",
                table: "Cita");

            migrationBuilder.DropColumn(
                name: "horarioTecnico",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UsuarioIdid",
                table: "Cita");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Usuario",
                newName: "tipoUsuario");

            migrationBuilder.RenameColumn(
                name: "citaIdid",
                table: "CitaServicio",
                newName: "citaId");

            migrationBuilder.RenameColumn(
                name: "fechaHora",
                table: "Cita",
                newName: "hora");

            migrationBuilder.AlterColumn<int>(
                name: "tipoPersona",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "numeroRegistro",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "metodoPago",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "horario",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "Cita",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "horario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "Cita");

            migrationBuilder.RenameColumn(
                name: "tipoUsuario",
                table: "Usuario",
                newName: "Discriminator");

            migrationBuilder.RenameColumn(
                name: "citaId",
                table: "CitaServicio",
                newName: "citaIdid");

            migrationBuilder.RenameColumn(
                name: "hora",
                table: "Cita",
                newName: "fechaHora");

            migrationBuilder.AlterColumn<int>(
                name: "tipoPersona",
                table: "Usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "numeroRegistro",
                table: "Usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "metodoPago",
                table: "Usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "horarioTecnico",
                table: "Usuario",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioIdid",
                table: "Cita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CitaServicio_citaIdid",
                table: "CitaServicio",
                column: "citaIdid");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_UsuarioIdid",
                table: "Cita",
                column: "UsuarioIdid");

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Usuario_UsuarioIdid",
                table: "Cita",
                column: "UsuarioIdid",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CitaServicio_Cita_citaIdid",
                table: "CitaServicio",
                column: "citaIdid",
                principalTable: "Cita",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
