using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddHelpUkraineSheffieldGroup_Step1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "FriendlyName", "GeographicName", "GroupKey", "GroupName", "GroupType", "HomepageEnabled", "JoinGroupPopUpDetail", "LinkURL", "ParentGroupId", "ShiftsEnabled", "ShortName", "TasksEnabled" },
                values: new object[] { -36, "Help Ukraine Sheffield", "Help Ukraine Sheffield", "help-ukraine-sheffield", "Help Ukraine Sheffield", (byte)0, false, null, "/help-ukraine-sheffield", -35, false, "Help Ukraine Sheffield", true });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant", "TargetGroups" },
                values: new object[] { -36, "", (byte)19, (byte)4 });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "SuppressRecipientPersonalDetails", "TargetGroups" },
                values: new object[] { -36, "a", true, (byte)33, false, false, true, (byte)4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -36, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -36, "a" });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -36);
        }
    }
}
