using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveUkraineUsers_Step2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 1, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 7, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 10, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 11, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 34, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 34, 3511 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "ActivityCredentialSet",
                columns: new[] { "GroupID", "ActivityID", "CredentialSetID", "DisplayOrder" },
                values: new object[,]
                {
                    { -35, 34, 35, 0 },
                    { -35, 1, 35, 0 },
                    { -35, 7, 35, 0 },
                    { -35, 10, 35, 0 },
                    { -35, 11, 35, 0 },
                    { -35, 34, 3511, 0 }
                });
        }
    }
}
