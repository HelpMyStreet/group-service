using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class PopulateGroupCredentialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "DisplayOrder", "HowToAchieve", "Name" },
                values: new object[,]
                {
                    { -6, -1, (byte)1, 1, "Yoti App", "Yoti Identity Verification" },
                    { -5, -1, (byte)1, 1, "Yoti App", "Yoti Identity Verification" },
                    { -4, -1, (byte)1, 1, "Yoti App", "Yoti Identity Verification" },
                    { -3, -1, (byte)1, 1, "Yoti App", "Yoti Identity Verification" },
                    { -2, -1, (byte)1, 1, "Yoti App", "Yoti Identity Verification" },
                    { -1, -1, (byte)1, 1, "Yoti App", "Yoti Identity Verification" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -6, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -5, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -4, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -1, -1 });
        }
    }
}
