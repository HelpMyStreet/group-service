using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddRequestHelpFormVariant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "TargetGroups" },
                values: new object[,]
                {
                    { -11, "", false, (byte)13, false, true, (byte)4 },
                    { -11, "a", true, (byte)14, false, false, (byte)4 },
                    { -13, "", false, (byte)15, false, true, (byte)4 },
                    { -13, "a", true, (byte)16, false, false, (byte)4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -13, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -13, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -11, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -11, "a" });
        }
    }
}
