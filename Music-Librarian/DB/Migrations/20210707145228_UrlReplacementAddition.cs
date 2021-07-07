using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class UrlReplacementAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UrlReplacement",
                columns: new[] { "Id", "StringReplacement", "StringToReplace" },
                values: new object[] { 42, " ", "‘" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UrlReplacement",
                keyColumn: "Id",
                keyValue: 42);
        }
    }
}
