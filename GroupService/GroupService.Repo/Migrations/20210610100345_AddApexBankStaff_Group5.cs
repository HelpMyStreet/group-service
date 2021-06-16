using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddApexBankStaff_Group5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                columns: new[] { "RequestHelpFormVariantID", "SupportActivityID", "DisplayOrder", "IsPreSelected", "Label" },
                values: new object[] { (byte)16, 11, (byte)2, false, "Please notify me about any other roles (including unpaid volunteer roles)" });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                columns: new[] { "RequestHelpFormVariantID", "SupportActivityID", "DisplayOrder", "IsPreSelected", "Label" },
                values: new object[] { (byte)16, 32, (byte)1, false, "Covering bank staff vaccinator shifts (this is a paid role)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)16, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)16, 32 });
        }
    }
}
