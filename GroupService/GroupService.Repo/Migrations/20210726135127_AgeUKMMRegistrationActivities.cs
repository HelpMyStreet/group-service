using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AgeUKMMRegistrationActivities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                columns: new[] { "RequestHelpFormVariantID", "SupportActivityID", "DisplayOrder", "IsPreSelected", "Label" },
                values: new object[,]
                {
                    { (byte)17, 1, (byte)1, false, "Picking up groceries and other essentials (e.g. food, toiletries, household products etc.)" },
                    { (byte)17, 2, (byte)2, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)17, 3, (byte)3, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)17, 5, (byte)4, false, "Walking the dog" },
                    { (byte)17, 7, (byte)5, false, "Calling someone in need of a friendly chat" },
                    { (byte)17, 26, (byte)6, false, "In-person befriending (when restrictions allow)" },
                    { (byte)17, 10, (byte)7, false, "Reaching out to people in my area to check-in" },
                    { (byte)17, 30, (byte)8, false, "Taking out the bins on bin day" },
                    { (byte)17, 27, (byte)9, false, "Providing help with everyday practical tasks (e.g. changing a lightbulb, filling in forms etc.)" },
                    { (byte)17, 31, (byte)10, false, "Providing help booking COVID-19 tests or vaccination appointments" },
                    { (byte)17, 29, (byte)11, false, "Providing digital support for people struggling with technology" },
                    { (byte)17, 13, (byte)12, false, "Collecting and delivering a pre-prepared wellbeing package" },
                    { (byte)17, 16, (byte)13, false, "Providing transport for essential appointments" },
                    { (byte)17, 25, (byte)14, false, "Providing help in emergency situations (e.g. extreme weather)" },
                    { (byte)17, 33, (byte)15, false, "Giving my time to share my skills and interests with other people who are interested to learn more" },
                    { (byte)17, 11, (byte)16, false, "I may be able to help with other tasks, so please check with me." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 3 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 5 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 10 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 13 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 16 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 25 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 26 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 27 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 29 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 30 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 31 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)17, 33 });
        }
    }
}
