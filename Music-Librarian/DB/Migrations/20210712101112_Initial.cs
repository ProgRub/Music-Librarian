using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusicFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusicTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniToBaseDirectory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Argb = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrimeArtist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrimeArtist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UniFileFormat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniFileFormat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrlReplacement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StringToReplace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StringReplacement = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlReplacement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutDateTimes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearLyricsChangeDetailsException",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    OriginalArtist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalAlbum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewArtist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewAlbum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearLyricsChangeDetailsException", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    TotalTrackCount = table.Column<int>(type: "int", nullable: false),
                    TotalDiscCount = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Album_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumArtist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContributingArtists = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    TrackNumber = table.Column<int>(type: "int", nullable: false),
                    DiscNumber = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    PlayCount = table.Column<int>(type: "int", nullable: false),
                    Lyrics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Song_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Directories",
                columns: new[] { "Id", "MusicFrom", "MusicTo", "UniFrom", "UniToBaseDirectory" },
                values: new object[] { 1, "C:\\Users\\ruben\\Desktop", "C:\\Users\\ruben\\Desktop\\Test", "C:\\Users\\ruben\\Downloads", "C:\\Users\\ruben\\OneDrive - Universidade da Madeira\\Ano_3\\Semestre_2" });

            migrationBuilder.InsertData(
                table: "GrimeArtist",
                columns: new[] { "Id", "ArtistName" },
                values: new object[,]
                {
                    { 12, "P Money" },
                    { 11, "Giggs" },
                    { 10, "AJ Tracey" },
                    { 9, "Kano" },
                    { 8, "Stormzy" },
                    { 7, "Chip" },
                    { 13, "Yizzy" },
                    { 5, "Dave" },
                    { 4, "Wiley" },
                    { 3, "Skepta" },
                    { 2, "JME" },
                    { 1, "Frisco" },
                    { 6, "Dizzee Rascal" }
                });

            migrationBuilder.InsertData(
                table: "UniFileFormat",
                columns: new[] { "Id", "Description", "Extension" },
                values: new object[,]
                {
                    { 5, "Compressed Files", ".rar" },
                    { 3, "Word Files", ".docx" },
                    { 4, "Compressed Files", ".zip" },
                    { 1, "PDF Files", ".pdf" },
                    { 2, "Word Files", ".doc" }
                });

            migrationBuilder.InsertData(
                table: "UrlReplacement",
                columns: new[] { "Id", "StringReplacement", "StringToReplace" },
                values: new object[,]
                {
                    { 31, " ", "!" },
                    { 24, " ", "=" },
                    { 25, "e", "é" },
                    { 26, "a", "à" },
                    { 27, "a", "â" },
                    { 28, "n", "ñ" },
                    { 29, "at", "@" },
                    { 30, " ", "..." },
                    { 32, " ", "?" },
                    { 42, " ", "‘" },
                    { 34, " ", "$" },
                    { 35, " ", "–" },
                    { 36, " ", ":" },
                    { 37, " ", "ꞌ" },
                    { 38, "", "." },
                    { 39, " ", "%" },
                    { 40, " ", "-" },
                    { 41, "o", "ō" },
                    { 23, "", "+" },
                    { 33, " ", "#" },
                    { 22, " ", ")" },
                    { 14, "", "’" },
                    { 20, " ", "_" }
                });

            migrationBuilder.InsertData(
                table: "UrlReplacement",
                columns: new[] { "Id", "StringReplacement", "StringToReplace" },
                values: new object[,]
                {
                    { 1, "pt ", "pt." },
                    { 2, "part ", "part." },
                    { 3, "pts ", "pts." },
                    { 4, "mr ", "mr." },
                    { 5, "vol ", "vol." },
                    { 6, " ", "ꞌ." },
                    { 7, " ", "/" },
                    { 21, " ", "(" },
                    { 9, " ", "<" },
                    { 8, " ", ">" },
                    { 11, " ", "*" },
                    { 12, " ", "“" },
                    { 13, " ", "”" },
                    { 15, " ", "\"" },
                    { 16, " ", "…" },
                    { 17, "And", "&" },
                    { 18, " ", "," },
                    { 19, " ", "|" },
                    { 10, "", "'" }
                });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "Name", "WorkoutDateTimes" },
                values: new object[,]
                {
                    { 4, "The Power Start", null },
                    { 1, "The Complete Crush", null },
                    { 2, "Pace Breaker", null },
                    { 3, "Lunge Capacity", null },
                    { 6, "Burpee Beach", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_GenreId",
                table: "Album",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumId",
                table: "Song",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_GenreId",
                table: "Song",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Directories");

            migrationBuilder.DropTable(
                name: "GrimeArtist");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "UniFileFormat");

            migrationBuilder.DropTable(
                name: "UrlReplacement");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "YearLyricsChangeDetailsException");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
