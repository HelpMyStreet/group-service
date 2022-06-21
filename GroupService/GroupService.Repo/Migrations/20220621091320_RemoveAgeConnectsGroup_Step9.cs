using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveAgeConnectsGroup_Step9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "FriendlyName", "GeographicName", "GroupKey", "GroupName", "GroupType", "HomepageEnabled", "JoinGroupPopUpDetail", "LinkURL", "ParentGroupId", "ShiftsEnabled", "ShortName", "TasksEnabled" },
                values: new object[] { -23, "Age Connects Cardiff & the Vale", "Cardiff & the Vale", "ageconnects-cardiff", "Age Connects Cardiff & the Vale", (byte)1, true, @"Age Connects Cardiff & the Vale require two references, an Induction Session and (in most cases) a DBS check before you can start volunteering.

You will also be expected to make a minimum commitment of six months.", "/ageconnects-cardiff", null, false, "Age Connects Cardiff", true });
        }
    }
}
