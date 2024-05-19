using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackathonEarthquake.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MeetingPlaces",
                keyColumn: "Id",
                keyValue: 3,
                column: "NeighbourhoodId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MeetingPlaces",
                keyColumn: "Id",
                keyValue: 4,
                column: "NeighbourhoodId",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MeetingPlaces",
                keyColumn: "Id",
                keyValue: 3,
                column: "NeighbourhoodId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MeetingPlaces",
                keyColumn: "Id",
                keyValue: 4,
                column: "NeighbourhoodId",
                value: 2);
        }
    }
}
