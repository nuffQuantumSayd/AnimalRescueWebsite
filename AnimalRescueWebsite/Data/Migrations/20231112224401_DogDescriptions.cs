using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalRescueWebsite.Data.Migrations
{
    public partial class DogDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DogDescriptions",
                columns: table => new
                {
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogId = table.Column<int>(type: "int", nullable: false),
                    Characteristics = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoatLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Health = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoodInHomeWith = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdoptionFee = table.Column<double>(type: "float", nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogDescriptions", x => x.DescriptionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogDescriptions");
        }
    }
}
