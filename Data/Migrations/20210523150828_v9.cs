using Microsoft.EntityFrameworkCore.Migrations;

namespace pfe.Data.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnseignantStage");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_EnseignantId",
                table: "Stage",
                column: "EnseignantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stage_Enseignant_EnseignantId",
                table: "Stage",
                column: "EnseignantId",
                principalTable: "Enseignant",
                principalColumn: "EnseignantId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stage_Enseignant_EnseignantId",
                table: "Stage");

            migrationBuilder.DropIndex(
                name: "IX_Stage_EnseignantId",
                table: "Stage");

            migrationBuilder.CreateTable(
                name: "EnseignantStage",
                columns: table => new
                {
                    EncadrantInterneEnseignantId = table.Column<int>(type: "int", nullable: false),
                    StagesStageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnseignantStage", x => new { x.EncadrantInterneEnseignantId, x.StagesStageId });
                    table.ForeignKey(
                        name: "FK_EnseignantStage_Enseignant_EncadrantInterneEnseignantId",
                        column: x => x.EncadrantInterneEnseignantId,
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

            migrationBuilder.CreateIndex(
                name: "IX_EnseignantStage_StagesStageId",
                table: "EnseignantStage",
                column: "StagesStageId");
        }
    }
}
