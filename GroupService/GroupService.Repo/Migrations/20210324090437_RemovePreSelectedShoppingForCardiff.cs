using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemovePreSelectedShoppingForCardiff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)12, 1 },
                column: "IsPreSelected",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)12, 1 },
                column: "IsPreSelected",
                value: true);
        }
    }
}
