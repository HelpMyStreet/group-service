using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveDataLinkedToHLP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE  FROM [Group].[UserCredential]
                WHERE   GroupID = -4
                ");

            migrationBuilder.Sql(@"
                DELETE  FROM [Group].[UserRole]
                WHERE   GroupID = -4
                ");

            migrationBuilder.Sql(@"
                DELETE  FROM [Group].[UserRoleAudit]
                WHERE   GroupID = -4
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
