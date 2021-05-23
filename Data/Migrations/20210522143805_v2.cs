using Microsoft.EntityFrameworkCore.Migrations;

namespace pfe.Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tel",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "telephone",
                table: "Student",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "promotion",
                table: "Student",
                newName: "Promotion");

            migrationBuilder.RenameColumn(
                name: "prenom",
                table: "Student",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "nom",
                table: "Student",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "matricule",
                table: "Student",
                newName: "Matricule");

            migrationBuilder.RenameColumn(
                name: "genre",
                table: "Student",
                newName: "Genre");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Student",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "dateNaissance",
                table: "Student",
                newName: "DateNaissance");

            migrationBuilder.RenameColumn(
                name: "cne",
                table: "Student",
                newName: "Cne");

            migrationBuilder.RenameColumn(
                name: "cin",
                table: "Student",
                newName: "Cin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Student",
                newName: "telephone");

            migrationBuilder.RenameColumn(
                name: "Promotion",
                table: "Student",
                newName: "promotion");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Student",
                newName: "prenom");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Student",
                newName: "nom");

            migrationBuilder.RenameColumn(
                name: "Matricule",
                table: "Student",
                newName: "matricule");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Student",
                newName: "genre");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Student",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "DateNaissance",
                table: "Student",
                newName: "dateNaissance");

            migrationBuilder.RenameColumn(
                name: "Cne",
                table: "Student",
                newName: "cne");

            migrationBuilder.RenameColumn(
                name: "Cin",
                table: "Student",
                newName: "cin");

            migrationBuilder.AddColumn<string>(
                name: "tel",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
