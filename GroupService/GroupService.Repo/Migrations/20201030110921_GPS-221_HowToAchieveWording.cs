using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class GPS221_HowToAchieveWording : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, email Age UK Wirral to find out how they can check your ID at volunteers@ageukwirral.org.uk");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 2 },
                column: "HowToAchieve",
                value: "Email Age UK Wirral to request or register your DBS check at volunteers@ageukwirral.org.uk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 1 },
                column: "HowToAchieve",
                value: "Email the AgeUK Wirral team");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 2 },
                column: "HowToAchieve",
                value: "Email the AgeUK Wirral team");
        }
    }
}
