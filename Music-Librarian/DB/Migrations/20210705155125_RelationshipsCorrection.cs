using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class RelationshipsCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Song_GenreId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Album_GenreId",
                table: "Album");

            migrationBuilder.CreateIndex(
                name: "IX_Song_GenreId",
                table: "Song",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Album_GenreId",
                table: "Album",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Song_GenreId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Album_GenreId",
                table: "Album");

            migrationBuilder.CreateIndex(
                name: "IX_Song_GenreId",
                table: "Song",
                column: "GenreId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Album_GenreId",
                table: "Album",
                column: "GenreId",
                unique: true);
        }
    }
}
