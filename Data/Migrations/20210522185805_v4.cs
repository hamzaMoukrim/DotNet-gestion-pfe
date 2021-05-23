using Microsoft.EntityFrameworkCore.Migrations;

namespace pfe.Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnseignantStage_Enseignant_EnseignantsEnseignantId",
                table: "EnseignantStage");

            migrationBuilder.DropForeignKey(
                name: "FK_EnseignantStage_Stage_StagesStageId",
                table: "EnseignantStage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnseignantStage",
                table: "EnseignantStage");

            migrationBuilder.RenameColumn(
                name: "StagesStageId",
                table: "EnseignantStage",
                newName: "StageId");

            migrationBuilder.RenameColumn(
                name: "EnseignantsEnseignantId",
                table: "EnseignantStage",
                newName: "EnseignantId");

            migrationBuilder.RenameIndex(
                name: "IX_EnseignantStage_StagesStageId",
                table: "EnseignantStage",
                newName: "IX_EnseignantStage_StageId");

            migrationBuilder.AddColumn<int>(
                name: "EnseignantStageId",
                table: "EnseignantStage",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnseignantStage",
                table: "EnseignantStage",
                column: "EnseignantStageId");

            migrationBuilder.CreateIndex(
                name: "IX_EnseignantStage_EnseignantId",
                table: "EnseignantStage",
                column: "EnseignantId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnseignantStage_Enseignant_EnseignantId",
                table: "EnseignantStage",
                column: "EnseignantId",
                principalTable: "Enseignant",
                principalColumn: "EnseignantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnseignantStage_Stage_StageId",
                table: "EnseignantStage",
                column: "StageId",
                principalTable: "Stage",
                principalColumn: "StageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnseignantStage_Enseignant_EnseignantId",
                table: "EnseignantStage");

            migrationBuilder.DropForeignKey(
                name: "FK_EnseignantStage_Stage_StageId",
                table: "EnseignantStage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnseignantStage",
                table: "EnseignantStage");

            migrationBuilder.DropIndex(
                name: "IX_EnseignantStage_EnseignantId",
                table: "EnseignantStage");

            migrationBuilder.DropColumn(
                name: "EnseignantStageId",
                table: "EnseignantStage");

            migrationBuilder.RenameColumn(
                name: "StageId",
                table: "EnseignantStage",
                newName: "StagesStageId");

            migrationBuilder.RenameColumn(
                name: "EnseignantId",
                table: "EnseignantStage",
                newName: "EnseignantsEnseignantId");

            migrationBuilder.RenameIndex(
                name: "IX_EnseignantStage_StageId",
                table: "EnseignantStage",
                newName: "IX_EnseignantStage_StagesStageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnseignantStage",
                table: "EnseignantStage",
                columns: new[] { "EnseignantsEnseignantId", "StagesStageId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EnseignantStage_Enseignant_EnseignantsEnseignantId",
                table: "EnseignantStage",
                column: "EnseignantsEnseignantId",
                principalTable: "Enseignant",
                principalColumn: "EnseignantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnseignantStage_Stage_StagesStageId",
                table: "EnseignantStage",
                column: "StagesStageId",
                principalTable: "Stage",
                principalColumn: "StageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
