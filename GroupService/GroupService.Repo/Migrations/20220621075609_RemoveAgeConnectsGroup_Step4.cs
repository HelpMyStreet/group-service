using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveAgeConnectsGroup_Step4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "CredentialSet",
                keyColumns: new[] { "ID", "GroupID", "CredentialID" },
                keyValues: new object[] { 23, -23, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
