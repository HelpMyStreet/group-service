using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RevertRequestFormForLincolnshireVolunteers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                column: "TasksEnabled",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -12, "a" },
                columns: new[] { "RequestHelpFormVariant", "RequestorDefinedByGroup" },
                values: new object[] { (byte)18, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                column: "TasksEnabled",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -12, "a" },
                columns: new[] { "RequestHelpFormVariant", "RequestorDefinedByGroup" },
                values: new object[] { (byte)32, false });
        }
    }
}
