using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ChangePopupTextToMarkDown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23,
                column: "JoinGroupPopUpDetail",
                value: @"Age Connects Cardiff & the Vale require two references, an Induction Session and (in most cases) a DBS check before you can start volunteering.

You will also be expected to make a minimum commitment of six months.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23,
                column: "JoinGroupPopUpDetail",
                value: "<p>Age Connects Cardiff & the Vale require two references, an Induction Session and (in most cases) a DBS check before you can start volunteering.</p><p>You will also be expected to make a minimum commitment of six months.</p>");
        }
    }
}
