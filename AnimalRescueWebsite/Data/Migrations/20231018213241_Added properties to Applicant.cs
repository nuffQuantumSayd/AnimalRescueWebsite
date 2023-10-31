using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalRescueWebsite.Data.Migrations
{
    public partial class AddedpropertiestoApplicant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfApplication",
                table: "Applicants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfApplication",
                table: "Applicants");
        }
    }
}
