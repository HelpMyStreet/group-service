using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class DeleteMeadowsCommunityHelpers_Step6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -24);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "FriendlyName", "GeographicName", "GroupKey", "GroupName", "GroupType", "HomepageEnabled", "JoinGroupPopUpDetail", "LinkURL", "ParentGroupId", "ShiftsEnabled", "ShortName", "TasksEnabled" },
                values: new object[] { -24, "Meadows Community Helpers", "The Meadows", "meadows-community-helpers", "Meadows Community Helpers", (byte)0, true, null, "/meadows-community-helpers", null, false, "Meadows", true });
        }
    }
}
