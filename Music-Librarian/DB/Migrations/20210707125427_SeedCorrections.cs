using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class SeedCorrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArtistName",
                value: "Dizzee Rascal");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 7,
                column: "ArtistName",
                value: "Chip");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 8,
                column: "ArtistName",
                value: "Stormzy");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 9,
                column: "ArtistName",
                value: "Kano");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 10,
                column: "ArtistName",
                value: "AJ Tracey");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 11,
                column: "ArtistName",
                value: "Giggs");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 12,
                column: "ArtistName",
                value: "P Money");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 13,
                column: "ArtistName",
                value: "Yizzy");

            migrationBuilder.InsertData(
                table: "UrlReplacement",
                columns: new[] { "Id", "StringReplacement", "StringToReplace" },
                values: new object[] { 41, "o", "ō" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UrlReplacement",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArtistName",
                value: "slowthai");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 7,
                column: "ArtistName",
                value: "Dizzee Rascal");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 8,
                column: "ArtistName",
                value: "Chip");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 9,
                column: "ArtistName",
                value: "Stormzy");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 10,
                column: "ArtistName",
                value: "Kano");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 11,
                column: "ArtistName",
                value: "AJ Tracey");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 12,
                column: "ArtistName",
                value: "Giggs");

            migrationBuilder.UpdateData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 13,
                column: "ArtistName",
                value: "P Money");

            migrationBuilder.InsertData(
                table: "GrimeArtist",
                columns: new[] { "Id", "ArtistName" },
                values: new object[] { 14, "Yizzy" });
        }
    }
}
