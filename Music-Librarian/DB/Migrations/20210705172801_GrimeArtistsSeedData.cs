using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class GrimeArtistsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GrimeArtist",
                columns: new[] { "Id", "ArtistName" },
                values: new object[,]
                {
                    { 1, "Frisco" },
                    { 2, "JME" },
                    { 3, "Skepta" },
                    { 4, "Wiley" },
                    { 5, "Dave" },
                    { 6, "slowthai" },
                    { 7, "Dizzee Rascal" },
                    { 8, "Chip" },
                    { 9, "Stormzy" },
                    { 10, "Kano" },
                    { 11, "AJ Tracey" },
                    { 12, "Giggs" },
                    { 13, "P Money" },
                    { 14, "Yizzy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GrimeArtist",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
