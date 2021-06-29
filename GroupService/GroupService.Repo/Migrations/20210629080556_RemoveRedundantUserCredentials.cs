using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveRedundantUserCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE  FROM [Group].[UserCredential]
                WHERE   CredentialID = 6
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
