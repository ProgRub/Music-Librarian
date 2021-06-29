using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class GenreColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Argb",
                table: "Genre",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Argb",
                table: "Genre");
        }
    }
}
