using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddUkraineRefugees_CredentialsStep3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "CredentialSet",
                columns: new[] { "ID", "GroupID", "CredentialID" },
                values: new object[] { 35, -35, -1 });            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "CredentialSet",
                keyColumns: new[] { "ID", "GroupID", "CredentialID" },
                keyValues: new object[] { 35, -35, -1 });
        }
    }
}
