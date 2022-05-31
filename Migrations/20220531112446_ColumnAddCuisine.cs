using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KukBuk.Migrations
{
    public partial class ColumnAddCuisine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cuisine",
                table: "Recipe",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cuisine",
                table: "Recipe");
        }
    }
}
