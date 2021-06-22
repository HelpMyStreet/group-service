using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddMissingMaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupMapDetails",
                columns: new[] { "GroupID", "MapLocationID", "Latitude", "Longitude", "ZoomLevel" },
                values: new object[] { -5, (byte)1, 53.498113m, -1.488587m, 14m });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupMapDetails",
                columns: new[] { "GroupID", "MapLocationID", "Latitude", "Longitude", "ZoomLevel" },
                values: new object[] { -6, (byte)1, 52.8925m, -1.150m, 14.6m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -6, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -5, (byte)1 });
        }
    }
}
