using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class DeleteMeadowsCommunityHelpers_Step2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 1, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 2, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 3, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 7, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 10, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 11, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 12, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 22, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 29, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 30, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -24, 31, 24 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "ActivityCredentialSet",
                columns: new[] { "GroupID", "ActivityID", "CredentialSetID", "DisplayOrder" },
                values: new object[,]
                {
                    { -24, 1, 24, 0 },
                    { -24, 12, 24, 0 },
                    { -24, 10, 24, 0 },
                    { -24, 2, 24, 0 },
                    { -24, 3, 24, 0 },
                    { -24, 29, 24, 0 },
                    { -24, 7, 24, 0 },
                    { -24, 30, 24, 0 },
                    { -24, 31, 24, 0 },
                    { -24, 22, 24, 0 },
                    { -24, 11, 24, 0 }
                });
        }
    }
}
