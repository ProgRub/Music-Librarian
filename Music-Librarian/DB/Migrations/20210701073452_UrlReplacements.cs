using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class UrlReplacements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "UrlReplacement",
                columns: new[] { "Id", "StringReplacement", "StringToReplace" },
                values: new object[,]
                {
                    { 1, "pt ", "pt." },
                    { 23, "", "+" },
                    { 24, " ", "=" },
                    { 25, "e", "é" },
                    { 26, "a", "à" },
                    { 27, "a", "â" },
                    { 28, "n", "ñ" },
                    { 29, "at", "@" },
                    { 22, " ", ")" },
                    { 30, " ", "..." },
                    { 32, " ", "?" },
                    { 33, " ", "#" },
                    { 34, " ", "$" },
                    { 35, " ", "–" },
                    { 36, " ", ":" },
                    { 37, " ", "ꞌ" },
                    { 38, " ", "." },
                    { 31, " ", "!" },
                    { 21, " ", "(" },
                    { 20, " ", "_" },
                    { 19, " ", "|" },
                    { 2, "part ", "part." },
                    { 3, "pts ", "pts." },
                    { 4, "mr ", "mr." },
                    { 5, "vol ", "vol." },
                    { 6, " ", "ꞌ." },
                    { 7, " ", "/" },
                    { 8, " ", ">" },
                    { 9, " ", "<" },
                    { 10, "", "'" },
                    { 11, " ", "*" },
                    { 12, " ", "“" },
                    { 13, " ", "”" },
                    { 14, "", "’" },
                    { 15, " ", "\"" },
                    { 16, " ", "…" },
                    { 17, "And", "&" },
                    { 18, " ", "," },
                    { 39, " ", "%" },
                    { 40, " ", "-" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrlReplacement");
        }
    }
}
