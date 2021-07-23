using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class WorkoutsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 1,
                column: "WorkoutDateTimes",
                value: "23/04/2020 01:04:24;01/07/2020 00:59:21;12/09/2020 00:54:22;29/09/2020 00:54:29;13/11/2020 00:52:09;20/12/2020 00:49:51;10/06/2021 00:46:24;24/06/2021 00:47:12");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 2,
                column: "WorkoutDateTimes",
                value: "26/03/2020 00:42:29;28/07/2020 00:54:37;28/08/2020 00:48:59;19/10/2020 00:48:34;17/12/2020 00:44:41;20/01/2021 00:42:19;04/02/2021 00:42:35;20/03/2021 00:40:04;26/06/2021 00:43:16;11/07/2021 00:38:04");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 3,
                column: "WorkoutDateTimes",
                value: "09/04/2020 00:53:03;08/07/2020 00:47:52;26/07/2020 00:52:10;19/08/2020 00:47:41;22/11/2020 00:42:20;10/12/2020 00:46:01;19/12/2020 00:43:38;06/02/2021 00:44:38;21/03/2021 00:42:09;08/05/2021 00:44:45;25/05/2021 00:43:07");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 4,
                column: "WorkoutDateTimes",
                value: "31/03/2020 00:46:17;17/06/2020 00:51:58;28/06/2020 00:52:05;05/08/2020 00:48:16;21/05/2021 00:44:51");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 6,
                column: "WorkoutDateTimes",
                value: "26/03/2020 00:42:29;21/06/2020 00:47:52;18/11/2020 00:33:41;24/02/2021 00:36:11;06/04/2021 00:36:56;16/05/2021 00:42:31");

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "Name", "WorkoutDateTimes" },
                values: new object[] { 5, "The Descent", "14/08/2020 00:50:30;21/06/2020 00:47:52;17/09/2020 00:45:29;30/11/2020 00:43:25;28/02/2021 00:43:21;11/04/2021 00:43:00" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 1,
                column: "WorkoutDateTimes",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 2,
                column: "WorkoutDateTimes",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 3,
                column: "WorkoutDateTimes",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 4,
                column: "WorkoutDateTimes",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 6,
                column: "WorkoutDateTimes",
                value: null);
        }
    }
}
