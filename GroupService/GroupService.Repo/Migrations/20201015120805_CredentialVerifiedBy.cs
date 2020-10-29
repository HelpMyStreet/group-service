using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class CredentialVerifiedBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "CredentialVerifiedById",
                schema: "Group",
                table: "GroupCredential",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, -1 },
                column: "CredentialVerifiedById",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 1 },
                column: "CredentialVerifiedById",
                value: (byte)2);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 2 },
                column: "CredentialVerifiedById",
                value: (byte)2);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -6, -1 },
                column: "CredentialVerifiedById",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -5, -1 },
                column: "CredentialVerifiedById",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -4, -1 },
                column: "CredentialVerifiedById",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, -1 },
                column: "CredentialVerifiedById",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, -1 },
                column: "CredentialVerifiedById",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -1, -1 },
                column: "CredentialVerifiedById",
                value: (byte)1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CredentialVerifiedById",
                schema: "Group",
                table: "GroupCredential");
        }
    }
}
