using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class DefaultDirectories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Directories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directories",
                table: "Directories",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Directories",
                columns: new[] { "Id", "MusicFrom", "MusicTo", "UniFrom", "UniToBaseDirectory" },
                values: new object[] { 1, "C:\\Users\\ruben\\Desktop", "C:\\Users\\ruben\\Desktop\\Test", "C:\\Users\\ruben\\Downloads", "C:\\Users\\ruben\\OneDrive - Universidade da Madeira\\Ano_3\\Semestre_2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Directories",
                table: "Directories");

            migrationBuilder.DeleteData(
                table: "Directories",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Directories");
        }
    }
}
