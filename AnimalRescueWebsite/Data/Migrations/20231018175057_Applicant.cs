using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalRescueWebsite.Data.Migrations
{
    public partial class Applicant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    ApplicantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantOccupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.ApplicantId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicants");
        }
    }
}
