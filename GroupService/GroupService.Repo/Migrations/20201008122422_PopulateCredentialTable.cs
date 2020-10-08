using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class PopulateCredentialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Credential",
                columns: new[] { "ID", "Name" },
                values: new object[] { -1, "IdentityVerifiedByYoti" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "Credential",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "ManuallyVerified" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "Credential",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "DBS Check" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
