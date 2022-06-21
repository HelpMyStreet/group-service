using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class EditJoinUpTextForUkraineGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -35,
                column: "JoinGroupPopUpDetail",
                value: "This group has been created to help prospective UK hosts find a suitable match for the UK Government Homes for Ukraine Scheme. Please only register if the following apply:<ul><li>You are 18 or over</li><li>You are able to offer accommodation for at least 6 months</li><li>You are a British citizen or have leave to remain in the UK for at least 6 months</li><li>You are looking to be a sponsor for UK Government Homes for Ukraine Scheme</li><li>You will submit a separate application to the UK Government Homes for Ukraine Scheme once a match has been confirmed</li></ul>You will need to verify your identity with photographic ID to access a match using this site. The UK Government may also carry out their own checks following an application to the scheme. Please only continue with your registration if you can meet these terms.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
