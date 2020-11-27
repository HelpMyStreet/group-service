using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ChangeBaldertonGroupKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8,
                column: "GroupKey",
                value: "balderton");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, please email us to find out more about our manual ID check at baldertoncs@helpmystreet.org");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8,
                column: "GroupKey",
                value: "ageuknottsbalderton");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, please email us to find out more about our manual ID at baldertoncs@helpmystreet.org");
        }
    }
}
