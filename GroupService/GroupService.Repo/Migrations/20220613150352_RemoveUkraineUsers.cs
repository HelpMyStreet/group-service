using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveUkraineUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM [Group].[UserRole]
                WHERE   GroupID=-35
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
