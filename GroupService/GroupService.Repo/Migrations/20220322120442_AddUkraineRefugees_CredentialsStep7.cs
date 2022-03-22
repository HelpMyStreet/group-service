using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddUkraineRefugees_CredentialsStep7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "CredentialSet",
                columns: new[] { "ID", "GroupID", "CredentialID" },
                values: new object[] { 3511, -35, 11 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "CredentialSet",
                keyColumns: new[] { "ID", "GroupID", "CredentialID" },
                keyValues: new object[] { 3511, -35, 11 });
        }
    }
}
