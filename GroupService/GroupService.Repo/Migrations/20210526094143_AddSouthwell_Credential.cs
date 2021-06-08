using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddSouthwell_Credential : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Credential",
                columns: new[] { "ID", "Name" },
                values: new object[] { 7, "Policies & Procedures" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CredentialTypes",
                columns: new[] { "ID", "Name" },
                values: new object[] { 5, "PolicyAgreement" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "CredentialTypes",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
