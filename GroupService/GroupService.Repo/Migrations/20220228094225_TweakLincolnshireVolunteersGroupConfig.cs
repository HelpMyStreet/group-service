using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakLincolnshireVolunteersGroupConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "GeographicName", "ShiftsEnabled", "TasksEnabled" },
                values: new object[] { "Lincolnshire Volunteers", false, true }); 

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -12, "a" },
                column: "RequestorDefinedByGroup",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "GeographicName", "ShiftsEnabled", "TasksEnabled" },
                values: new object[] { null, true, false });

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -12, "a" },
                column: "RequestorDefinedByGroup",
                value: true);
        }
    }
}
