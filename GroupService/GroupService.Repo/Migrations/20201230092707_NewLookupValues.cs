using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class NewLookupValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "GroupKey", "GroupName", "ParentGroupId" },
                values: new object[,]
                {
                    { -11, "southkentcoast", "Age UK South Kent Coast", null },
                    { -13, "favershamandsittingbourne", "Age UK Faversham & Sittingbourne", null }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 13, "AgeUKSouthKentCoast_Public" },
                    { 14, "AgeUKSouthKentCoast_RequestSubmitter" },
                    { 15, "AgeUKFavershamAndSittingbourne_Public" },
                    { 16, "AgeUKFavershamAndSittingbourne_RequestSubmitter" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivity",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 17, "FrontOfHouseAdmin" },
                    { 18, "BackOfficeAdmin" },
                    { 19, "HealthcareAssistant" },
                    { 20, "Steward" },
                    { 21, "MealsOnWheels" },
                    { 22, "VolunteerSupport" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 22);
        }
    }
}
