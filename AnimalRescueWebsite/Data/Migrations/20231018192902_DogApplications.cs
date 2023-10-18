using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalRescueWebsite.Data.Migrations
{
    public partial class DogApplications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DogApplications",
                columns: table => new
                {
                    DogApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dog = table.Column<int>(type: "int", nullable: false),
                    Applicant = table.Column<int>(type: "int", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogApplications");
        }
    }
}
