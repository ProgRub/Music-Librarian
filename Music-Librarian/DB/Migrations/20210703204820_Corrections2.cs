using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class Corrections2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SongHasContributingArtistsEnumerable_Artist_ArtistId",
                table: "SongHasContributingArtistsEnumerable");

            migrationBuilder.DropForeignKey(
                name: "FK_SongHasContributingArtistsEnumerable_Song_SongId",
                table: "SongHasContributingArtistsEnumerable");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutHasTimesEnumerable_Workout_WorkoutId",
                table: "WorkoutHasTimesEnumerable");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutHasTimesEnumerable_WorkoutTimes_WorkoutTimeId",
                table: "WorkoutHasTimesEnumerable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutTimes",
                table: "WorkoutTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutHasTimesEnumerable",
                table: "WorkoutHasTimesEnumerable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SongHasContributingArtistsEnumerable",
                table: "SongHasContributingArtistsEnumerable");

            migrationBuilder.RenameTable(
                name: "WorkoutTimes",
                newName: "WorkoutTime");

            migrationBuilder.RenameTable(
                name: "WorkoutHasTimesEnumerable",
                newName: "WorkoutHasTimes");

            migrationBuilder.RenameTable(
                name: "SongHasContributingArtistsEnumerable",
                newName: "SongHasContributingArtists");

            migrationBuilder.RenameIndex(
                name: "IX_WorkoutHasTimesEnumerable_WorkoutId",
                table: "WorkoutHasTimes",
                newName: "IX_WorkoutHasTimes_WorkoutId");

            migrationBuilder.RenameIndex(
                name: "IX_SongHasContributingArtistsEnumerable_SongId",
                table: "SongHasContributingArtists",
                newName: "IX_SongHasContributingArtists_SongId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutTime",
                table: "WorkoutTime",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutHasTimes",
                table: "WorkoutHasTimes",
                columns: new[] { "WorkoutTimeId", "WorkoutId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SongHasContributingArtists",
                table: "SongHasContributingArtists",
                columns: new[] { "ArtistId", "SongId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SongHasContributingArtists_Artist_ArtistId",
                table: "SongHasContributingArtists",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SongHasContributingArtists_Song_SongId",
                table: "SongHasContributingArtists",
                column: "SongId",
                principalTable: "Song",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutHasTimes_Workout_WorkoutId",
                table: "WorkoutHasTimes",
                column: "WorkoutId",
                principalTable: "Workout",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutHasTimes_WorkoutTime_WorkoutTimeId",
                table: "WorkoutHasTimes",
                column: "WorkoutTimeId",
                principalTable: "WorkoutTime",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SongHasContributingArtists_Artist_ArtistId",
                table: "SongHasContributingArtists");

            migrationBuilder.DropForeignKey(
                name: "FK_SongHasContributingArtists_Song_SongId",
                table: "SongHasContributingArtists");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutHasTimes_Workout_WorkoutId",
                table: "WorkoutHasTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutHasTimes_WorkoutTime_WorkoutTimeId",
                table: "WorkoutHasTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutTime",
                table: "WorkoutTime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutHasTimes",
                table: "WorkoutHasTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SongHasContributingArtists",
                table: "SongHasContributingArtists");

            migrationBuilder.RenameTable(
                name: "WorkoutTime",
                newName: "WorkoutTimes");

            migrationBuilder.RenameTable(
                name: "WorkoutHasTimes",
                newName: "WorkoutHasTimesEnumerable");

            migrationBuilder.RenameTable(
                name: "SongHasContributingArtists",
                newName: "SongHasContributingArtistsEnumerable");

            migrationBuilder.RenameIndex(
                name: "IX_WorkoutHasTimes_WorkoutId",
                table: "WorkoutHasTimesEnumerable",
                newName: "IX_WorkoutHasTimesEnumerable_WorkoutId");

            migrationBuilder.RenameIndex(
                name: "IX_SongHasContributingArtists_SongId",
                table: "SongHasContributingArtistsEnumerable",
                newName: "IX_SongHasContributingArtistsEnumerable_SongId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutTimes",
                table: "WorkoutTimes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutHasTimesEnumerable",
                table: "WorkoutHasTimesEnumerable",
                columns: new[] { "WorkoutTimeId", "WorkoutId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SongHasContributingArtistsEnumerable",
                table: "SongHasContributingArtistsEnumerable",
                columns: new[] { "ArtistId", "SongId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SongHasContributingArtistsEnumerable_Artist_ArtistId",
                table: "SongHasContributingArtistsEnumerable",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SongHasContributingArtistsEnumerable_Song_SongId",
                table: "SongHasContributingArtistsEnumerable",
                column: "SongId",
                principalTable: "Song",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutHasTimesEnumerable_Workout_WorkoutId",
                table: "WorkoutHasTimesEnumerable",
                column: "WorkoutId",
                principalTable: "Workout",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutHasTimesEnumerable_WorkoutTimes_WorkoutTimeId",
                table: "WorkoutHasTimesEnumerable",
                column: "WorkoutTimeId",
                principalTable: "WorkoutTimes",
                principalColumn: "Id");
        }
    }
}
