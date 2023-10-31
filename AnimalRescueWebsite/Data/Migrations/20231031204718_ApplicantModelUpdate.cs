using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalRescueWebsite.Data.Migrations
{
    public partial class ApplicantModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_Dogs_Dog",
                table: "Applicants");

            migrationBuilder.DropIndex(
                name: "IX_Applicants_Dog",
                table: "Applicants");

            migrationBuilder.RenameColumn(
                name: "Dog",
                table: "Applicants",
                newName: "dog");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dog",
                table: "Applicants",
                newName: "Dog");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_Dog",
                table: "Applicants",
                column: "Dog");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_Dogs_Dog",
                table: "Applicants",
                column: "Dog",
                principalTable: "Dogs",
                principalColumn: "DogId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
