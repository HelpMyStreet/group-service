using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveRegistrationJourney : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -34, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -33, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -32, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -23, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -13, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -12, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -11, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -10, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -9, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -8, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -5, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -3, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -2, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant", "TargetGroups" },
                values: new object[,]
                {
                    { -2, "", (byte)2, (byte)5 },
                    { -3, "", (byte)3, (byte)5 },
                    { -5, "", (byte)0, (byte)5 },
                    { -8, "", (byte)6, (byte)5 },
                    { -9, "", (byte)7, (byte)5 },
                    { -10, "", (byte)6, (byte)5 },
                    { -11, "", (byte)8, (byte)5 },
                    { -13, "", (byte)9, (byte)5 },
                    { -12, "", (byte)10, (byte)5 },
                    { -23, "", (byte)12, (byte)5 },
                    { -32, "", (byte)16, (byte)0 },
                    { -33, "", (byte)17, (byte)0 },
                    { -34, "", (byte)18, (byte)5 }
                });
        }
    }
}
