using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalRescueWebsite.Data.Migrations
{
    public partial class RemovedDogPicColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DogPic",
                table: "Dogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DogPic",
                table: "Dogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
