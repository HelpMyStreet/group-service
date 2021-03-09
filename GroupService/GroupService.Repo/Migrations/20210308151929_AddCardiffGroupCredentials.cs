using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddCardiffGroupCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Credential",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 4, "Volunteer Training" },
                    { 5, "Reference 1" },
                    { 6, "Reference 2" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CredentialTypes",
                columns: new[] { "ID", "Name" },
                values: new object[] { 4, "References" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "CredentialTypes",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
