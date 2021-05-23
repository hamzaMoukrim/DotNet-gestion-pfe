using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pfe.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enseignant",
                columns: table => new
                {
                    EnseignantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enseignant", x => x.EnseignantId);
                });

            migrationBuilder.CreateTable(
                name: "Filiere",
                columns: table => new
                {
                    FiliereId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomFiliere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiere", x => x.FiliereId);
                });

            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    StageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EncadrantExterne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganismeAceuil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaysStage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sujet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VilleStage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.StageId);
                });

            migrationBuilder.CreateTable(
                name: "EnseignantStage",
                columns: table => new
                {
                    EnseignantsEnseignantId = table.Column<int>(type: "int", nullable: false),
                    StagesStageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnseignantStage", x => new { x.EnseignantsEnseignantId, x.StagesStageId });
                    table.ForeignKey(
                        name: "FK_EnseignantStage_Enseignant_EnseignantsEnseignantId",
                        column: x => x.EnseignantsEnseignantId,
                        principalTable: "Enseignant",
                        principalColumn: "EnseignantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnseignantStage_Stage_StagesStageId",
                        column: x => x.StagesStageId,
                        principalTable: "Stage",
                        principalColumn: "StageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matricule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FiliereId = table.Column<int>(type: "int", nullable: true),
                    promotion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Filiere_FiliereId",
                        column: x => x.FiliereId,
                        principalTable: "Filiere",
                        principalColumn: "FiliereId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Stage_StageId",
                        column: x => x.StageId,
                        principalTable: "Stage",
                        principalColumn: "StageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnseignantStage_StagesStageId",
                table: "EnseignantStage",
                column: "StagesStageId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FiliereId",
                table: "Student",
                column: "FiliereId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StageId",
                table: "Student",
                column: "StageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnseignantStage");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Enseignant");

            migrationBuilder.DropTable(
                name: "Filiere");

            migrationBuilder.DropTable(
                name: "Stage");
        }
    }
}
