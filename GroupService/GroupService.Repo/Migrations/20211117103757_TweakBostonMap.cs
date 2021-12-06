using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakBostonMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HowToAchieve",
                schema: "Group",
                table: "GroupCredential",
                unicode: false,
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)",
                oldUnicode: false,
                oldMaxLength: 400);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -34, (byte)0 },
                columns: new[] { "Latitude", "Longitude", "ZoomLevel" },
                values: new object[] { 52.979m, -0.02500m, 13.8m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HowToAchieve",
                schema: "Group",
                table: "GroupCredential",
                type: "varchar(400)",
                unicode: false,
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -34, (byte)0 },
                columns: new[] { "Latitude", "Longitude", "ZoomLevel" },
                values: new object[] { 52.98035m, -0.02765m, 11.8m });
        }
    }
}
