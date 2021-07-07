using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveYotiVerificationForCardiff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "CredentialSet",
                keyColumns: new[] { "ID", "GroupID", "CredentialID" },
                keyValues: new object[] { 23, -23, -1 });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "References");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 1 },
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 2 },
                column: "DisplayOrder",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 },
                column: "DisplayOrder",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 5 },
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 2, "References" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "Reference 1");

            migrationBuilder.InsertData(
                schema: "Group",
                table: "CredentialSet",
                columns: new[] { "ID", "GroupID", "CredentialID" },
                values: new object[] { 23, -23, -1 });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 1 },
                column: "DisplayOrder",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 2 },
                column: "DisplayOrder",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 },
                column: "DisplayOrder",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 5 },
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 3, "Reference 1" });
        }
    }
}
