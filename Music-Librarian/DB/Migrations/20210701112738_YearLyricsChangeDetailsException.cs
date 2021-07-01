using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class YearLyricsChangeDetailsException : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YearLyricsChangeDetailsException",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    OriginalArtist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalAlbum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewArtist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewAlbum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearLyricsChangeDetailsException", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YearLyricsChangeDetailsException");
        }
    }
}
