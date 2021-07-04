using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class NoArtistEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Artist_ArtistId",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Artist_AlbumArtistId",
                table: "Song");

            migrationBuilder.DropTable(
                name: "SongHasContributingArtists");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropIndex(
                name: "IX_Song_AlbumArtistId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Album_ArtistId",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "AlbumArtistId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Album");

            migrationBuilder.AddColumn<string>(
                name: "AlbumArtist",
                table: "Song",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContributingArtists",
                table: "Song",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Album",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumArtist",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "ContributingArtists",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Album");

            migrationBuilder.AddColumn<int>(
                name: "AlbumArtistId",
                table: "Song",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Album",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SongHasContributingArtists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongHasContributingArtists", x => new { x.ArtistId, x.SongId });
                    table.ForeignKey(
                        name: "FK_SongHasContributingArtists_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SongHasContributingArtists_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumArtistId",
                table: "Song",
                column: "AlbumArtistId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Album_ArtistId",
                table: "Album",
                column: "ArtistId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SongHasContributingArtists_SongId",
                table: "SongHasContributingArtists",
                column: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Artist_ArtistId",
                table: "Album",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Artist_AlbumArtistId",
                table: "Song",
                column: "AlbumArtistId",
                principalTable: "Artist",
                principalColumn: "Id");
        }
    }
}
