using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddCorrectApexEmailAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -20,
                column: "EmailAddress",
                value: "g.burroughs@nhs.net");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -20,
                column: "EmailAddress",
                value: "laura@factor-50.co.uk");
        }
    }
}
