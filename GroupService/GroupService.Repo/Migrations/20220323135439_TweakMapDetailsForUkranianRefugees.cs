using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakMapDetailsForUkranianRefugees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -35, (byte)0 },
                columns: new[] { "Latitude", "ZoomLevel" },
                values: new object[] { 54.55m, 5.1m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -35, (byte)0 },
                columns: new[] { "Latitude", "ZoomLevel" },
                values: new object[] { 55.0m, 5.3m });
        }
    }
}
