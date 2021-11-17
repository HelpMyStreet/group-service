using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class DeleteNeverUsedGroups_Step3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -25);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "FriendlyName", "GeographicName", "GroupKey", "GroupName", "GroupType", "HomepageEnabled", "JoinGroupPopUpDetail", "LinkURL", "ParentGroupId", "ShiftsEnabled", "ShortName", "TasksEnabled" },
                values: new object[] { -25, null, null, "mansfield-cvs", "Mansfield CVS", (byte)0, false, null, null, null, true, null, false });
        }
    }
}
