using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolPersonelsManagement.Migrations
{
    public partial class SaveAllFiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassMainTeacherId",
                table: "Classrooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_ClassMainTeacherId",
                table: "Classrooms",
                column: "ClassMainTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Teachers_ClassMainTeacherId",
                table: "Classrooms",
                column: "ClassMainTeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Teachers_ClassMainTeacherId",
                table: "Classrooms");

            migrationBuilder.DropIndex(
                name: "IX_Classrooms_ClassMainTeacherId",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "ClassMainTeacherId",
                table: "Classrooms");
        }
    }
}
