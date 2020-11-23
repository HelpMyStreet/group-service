using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakBaldertonConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8,
                column: "GroupName",
                value: "Balderton Community Support");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, please email us to find out more about our manual ID at baldertoncs@helpmystreet.org");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8,
                column: "GroupName",
                value: "Age UK Notts (Balderton)");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, email Age UK Notts Balderton to find out how they can check your ID at baldertoncs@helpmystreet.org");
        }
    }
}
