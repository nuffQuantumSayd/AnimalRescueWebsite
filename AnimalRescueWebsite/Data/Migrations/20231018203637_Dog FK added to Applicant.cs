using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalRescueWebsite.Data.Migrations
{
    public partial class DogFKaddedtoApplicant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogApplications");

            migrationBuilder.AddColumn<int>(
                name: "Dog",
                table: "Applicants",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_Dogs_Dog",
                table: "Applicants");

            migrationBuilder.DropIndex(
                name: "IX_Applicants_Dog",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Dog",
                table: "Applicants");

            migrationBuilder.CreateTable(
                name: "DogApplications",
                columns: table => new
                {
                    DogApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Applicant = table.Column<int>(type: "int", nullable: false),
                    Dog = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogApplications", x => x.DogApplicationId);
                    table.ForeignKey(
                        name: "FK_DogApplications_Applicants_Applicant",
                        column: x => x.Applicant,
                        principalTable: "Applicants",
                        principalColumn: "ApplicantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DogApplications_Dogs_Dog",
                        column: x => x.Dog,
                        principalTable: "Dogs",
                        principalColumn: "DogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DogApplications_Applicant",
                table: "DogApplications",
                column: "Applicant");

            migrationBuilder.CreateIndex(
                name: "IX_DogApplications_Dog",
                table: "DogApplications",
                column: "Dog");
        }
    }
}
