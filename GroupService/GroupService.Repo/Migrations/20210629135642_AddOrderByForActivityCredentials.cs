using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddOrderByForActivityCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                schema: "Group",
                table: "ActivityCredentialSet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 1, 231 },
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 1, 234 },
                column: "DisplayOrder",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 2, 234 },
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 7, 234 },
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 11, 231 },
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 11, 234 },
                column: "DisplayOrder",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 16, 231 },
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 16, 234 },
                column: "DisplayOrder",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 22, 234 },
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 26, 231 },
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 26, 234 },
                column: "DisplayOrder",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 27, 231 },
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 27, 234 },
                column: "DisplayOrder",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                schema: "Group",
                table: "ActivityCredentialSet");
        }
    }
}
