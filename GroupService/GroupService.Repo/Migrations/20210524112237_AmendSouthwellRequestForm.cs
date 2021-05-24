using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AmendSouthwellRequestForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -31, "a" });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "SuppressRecipientPersonalDetails", "TargetGroups" },
                values: new object[] { -31, "", false, (byte)25, false, false, false, (byte)4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -31, "" });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "SuppressRecipientPersonalDetails", "TargetGroups" },
                values: new object[] { -31, "a", true, (byte)25, false, false, false, (byte)4 });
        }
    }
}
