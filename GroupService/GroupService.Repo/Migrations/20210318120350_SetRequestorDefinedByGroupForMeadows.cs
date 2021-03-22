using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class SetRequestorDefinedByGroupForMeadows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -24, "a" },
                column: "RequestorDefinedByGroup",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -24, "a" },
                column: "RequestorDefinedByGroup",
                value: true);
        }
    }
}
