using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class FE553AddRequestsRequireApproval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RequestsRequireApproval",
                schema: "Website",
                table: "RequestHelpJourney",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestsRequireApproval",
                schema: "Website",
                table: "RequestHelpJourney");
        }
    }
}
