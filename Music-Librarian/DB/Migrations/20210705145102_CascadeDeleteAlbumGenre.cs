using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class CascadeDeleteAlbumGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Genre_GenreId",
                table: "Album");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Genre_GenreId",
                table: "Album",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Genre_GenreId",
                table: "Album");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Genre_GenreId",
                table: "Album",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id");
        }
    }
}
