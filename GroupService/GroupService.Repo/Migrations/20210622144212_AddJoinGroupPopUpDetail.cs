using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddJoinGroupPopUpDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JoinGroupPopUpDetail",
                schema: "Group",
                table: "Group",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23,
                column: "JoinGroupPopUpDetail",
                value: "<p>Age Connects Cardiff & the Vale require two references, an Induction Session and (in most cases) a DBS check before you can start volunteering.</p><p>You will also be expected to make a minimum commitment of six months.</p>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JoinGroupPopUpDetail",
                schema: "Group",
                table: "Group");
        }
    }
}
