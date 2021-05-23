using Microsoft.EntityFrameworkCore.Migrations;

namespace pfe.Data.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Filiere_FiliereId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Filiere");

            migrationBuilder.AlterColumn<int>(
                name: "FiliereId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Filiere_FiliereId",
                table: "Student",
                column: "FiliereId",
                principalTable: "Filiere",
                principalColumn: "FiliereId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Filiere_FiliereId",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "FiliereId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Filiere",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Filiere_FiliereId",
                table: "Student",
                column: "FiliereId",
                principalTable: "Filiere",
                principalColumn: "FiliereId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
