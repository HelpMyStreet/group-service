using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddJoinDetailsForUkranianGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -35,
                column: "JoinGroupPopUpDetail",
                value: @"To become a host / sponsor for people forced to escape their homeland you will need to be able to provide at least six months’ accommodation and can be living in any part of the UK. You must be over 18, and can be of any nationality, with any immigration status, providing you have at least 6 months’ leave to remain in the UK.

To ensure a safe and suitable environment for  those requiring accommodation, we’re going to be carrying out checks (background and in-person) on you as a sponsor, your family and the accommodation that you will provide.

Please only continue with your registration if you can meet these terms.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -35,
                column: "JoinGroupPopUpDetail",
                value: null);
        }
    }
}
