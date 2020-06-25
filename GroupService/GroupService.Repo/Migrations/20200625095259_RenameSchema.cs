using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RenameSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UserRoleAudit",
                schema: "Audit",
                newName: "UserRoleAudit",
                newSchema: "Group");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Audit");

            migrationBuilder.RenameTable(
                name: "UserRoleAudit",
                schema: "Group",
                newName: "UserRoleAudit",
                newSchema: "Audit");
        }
    }
}
