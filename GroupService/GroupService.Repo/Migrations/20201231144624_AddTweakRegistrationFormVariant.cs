using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddTweakRegistrationFormVariant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 7, "AgeUKNWK" },
                    { 8, "AgeUKSKC" },
                    { 9, "AgeUKFandS" }
                });

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -13, "" },
                column: "RegistrationFormVariant",
                value: (byte)9);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -11, "" },
                column: "RegistrationFormVariant",
                value: (byte)8);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -9, "" },
                column: "RegistrationFormVariant",
                value: (byte)7);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -13, "" },
                column: "RegistrationFormVariant",
                value: (byte)0);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -11, "" },
                column: "RegistrationFormVariant",
                value: (byte)0);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -9, "" },
                column: "RegistrationFormVariant",
                value: (byte)0);
        }
    }
}
