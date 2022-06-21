using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveAgeConnectsGroup_Step1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM [Group].[UserRole]
                WHERE   GroupID=-23
            ");

            migrationBuilder.Sql(@"
                DELETE FROM [Group].[UserCredential]
                WHERE   GroupID=-23
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
