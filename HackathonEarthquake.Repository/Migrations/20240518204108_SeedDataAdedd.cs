using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackathonEarthquake.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdedd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "İstanbul" });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[] { 1, 1, "Eyüp" });

            migrationBuilder.InsertData(
                table: "Neighbourhoods",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[] { 1, 1, "ÇırÇır" });

            migrationBuilder.InsertData(
                table: "Streets",
                columns: new[] { "Id", "Name", "NeighbourhoodId" },
                values: new object[] { 1, "Funda", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Neighbourhoods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
