using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ChangeTargetGroupForNHSVRDemoGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -40, "a" },
                column: "TargetGroups",
                value: (byte)3);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -39, "a" },
                column: "TargetGroups",
                value: (byte)3);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -38, "a" },
                column: "TargetGroups",
                value: (byte)1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -40, "a" },
                column: "TargetGroups",
                value: (byte)0);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -39, "a" },
                column: "TargetGroups",
                value: (byte)0);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -38, "a" },
                column: "TargetGroups",
                value: (byte)0);
        }
    }
}
