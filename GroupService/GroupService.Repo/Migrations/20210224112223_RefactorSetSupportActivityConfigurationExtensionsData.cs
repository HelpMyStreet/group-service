using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RefactorSetSupportActivityConfigurationExtensionsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "SupportActivity",
                columns: new[] { "SupportActivityID", "AutoSignUpWhenOtherSelected" },
                values: new object[,]
                {
                    { 4, false },
                    { 8, false },
                    { 9, false },
                    { 11, false },
                    { 12, false },
                    { 14, false },
                    { 16, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 16);
        }
    }
}
