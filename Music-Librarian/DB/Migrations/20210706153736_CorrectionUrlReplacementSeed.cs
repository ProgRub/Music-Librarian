using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class CorrectionUrlReplacementSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UrlReplacement",
                keyColumn: "Id",
                keyValue: 38,
                column: "StringReplacement",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UrlReplacement",
                keyColumn: "Id",
                keyValue: 38,
                column: "StringReplacement",
                value: " ");
        }
    }
}
