using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveGroupMapDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -34, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -34, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -33, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -23, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -23, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -13, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -13, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -12, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -12, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -11, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -11, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -10, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -10, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -9, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -9, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -8, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -8, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -5, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -5, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -3, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -3, (byte)1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupMapDetails",
                columns: new[] { "GroupID", "MapLocationID", "Latitude", "Longitude", "ZoomLevel" },
                values: new object[,]
                {
                    { -5, (byte)0, 53.498113m, -1.488587m, 14m },
                    { -33, (byte)0, 53.4042239m, -2.7936289m, 11.8m },
                    { -23, (byte)0, 51.5022198m, -3.2752615m, 11m },
                    { -23, (byte)1, 51.5022198m, -3.2752615m, 11m },
                    { -12, (byte)0, 52.95m, -0.2m, 9m },
                    { -12, (byte)1, 53.196498m, -0.574294m, 9m },
                    { -9, (byte)0, 51.40020276537333m, 0.2950217005371014m, 12m },
                    { -9, (byte)1, 51.40020276537333m, 0.2950217005371014m, 11m },
                    { -13, (byte)0, 51.32681418199929m, 0.8065864663737088m, 12m },
                    { -34, (byte)0, 52.979m, -0.02500m, 13.8m },
                    { -13, (byte)1, 51.32681418199929m, 0.8065864663737088m, 12m },
                    { -11, (byte)1, 51.15670694376801m, 1.2906096124741184m, 12m },
                    { -10, (byte)0, 53.120254m, -0.811079m, 14m },
                    { -10, (byte)1, 53.120254m, -0.811079m, 12m },
                    { -8, (byte)0, 53.0561082m, -0.8m, 13.5m },
                    { -8, (byte)1, 53.0561082m, -0.8m, 12m },
                    { -3, (byte)0, 52.95m, -0.2m, 9m },
                    { -3, (byte)1, 53.2304334m, -0.5435425m, 9m },
                    { -5, (byte)1, 53.498113m, -1.488587m, 14m },
                    { -11, (byte)0, 51.15670694376801m, 1.2906096124741184m, 11m },
                    { -34, (byte)1, 52.979m, -0.02500m, 13.8m }
                });
        }
    }
}
