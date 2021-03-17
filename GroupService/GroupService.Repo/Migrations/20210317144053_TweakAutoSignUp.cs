using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakAutoSignUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 28,
                column: "AutoSignUpWhenOtherSelected",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 28,
                column: "AutoSignUpWhenOtherSelected",
                value: true);
        }
    }
}
