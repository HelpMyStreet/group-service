using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class PopulateNewRegFormActivities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 11, "Ruddington" });

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 11 },
                column: "DisplayOrder",
                value: (byte)13);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 11 },
                column: "DisplayOrder",
                value: (byte)11);

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                columns: new[] { "RequestHelpFormVariantID", "SupportActivityID", "DisplayOrder", "IsPreSelected", "Label" },
                values: new object[,]
                {
                    { (byte)0, 2, (byte)3, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)11, 11, (byte)13, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)11, 22, (byte)12, false, "Helping with events, admin duties or not-for-profit activities" },
                    { (byte)11, 10, (byte)11, false, "Reaching out to people in my area to check-in" },
                    { (byte)11, 9, (byte)10, false, "Providing remote support for parents and carers home-schooling their children" },
                    { (byte)11, 8, (byte)9, false, "Providing support over the phone to someone who may be anxious (relevant experience required e.g. mental health first-aider)" },
                    { (byte)11, 7, (byte)8, false, "Calling someone in need of a friendly chat" },
                    { (byte)11, 6, (byte)7, false, "Preparing and/or delivering a hot / pre-prepared meal" },
                    { (byte)11, 5, (byte)6, false, "Walking the dog" },
                    { (byte)11, 13, (byte)5, false, "Collecting and delivering a pre-prepared wellbeing package" },
                    { (byte)11, 3, (byte)4, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)11, 2, (byte)3, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)0, 12, (byte)2, false, "Supplying homemade face coverings" },
                    { (byte)11, 12, (byte)2, false, "Supplying homemade face coverings" },
                    { (byte)0, 1, (byte)1, true, "Picking up groceries and other essentials (e.g. food, toiletries, household products etc.)" },
                    { (byte)10, 22, (byte)9, false, "Helping with events, admin duties or not-for-profit activities" },
                    { (byte)3, 22, (byte)12, false, "Helping with events, admin duties or not-for-profit activities" },
                    { (byte)0, 11, (byte)12, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)0, 10, (byte)11, false, "Reaching out to people in my area to check-in" },
                    { (byte)0, 9, (byte)10, false, "Providing remote support for parents and carers home-schooling their children" },
                    { (byte)0, 8, (byte)9, false, "Providing support over the phone to someone who may be anxious (relevant experience required e.g. mental health first-aider)" },
                    { (byte)0, 7, (byte)8, false, "Calling someone in need of a friendly chat" },
                    { (byte)0, 6, (byte)7, false, "Preparing and/or delivering a hot / pre-prepared meal" },
                    { (byte)0, 5, (byte)6, false, "Walking the dog" },
                    { (byte)0, 13, (byte)5, false, "Collecting and delivering a pre-prepared wellbeing package" },
                    { (byte)0, 3, (byte)4, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)11, 1, (byte)1, true, "Picking up groceries and other essentials (e.g. food, toiletries, household products etc.)" },
                    { (byte)10, 25, (byte)10, false, "Providing help in emergency situations (e.g. extreme weather)" }
                });

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -6, "" },
                column: "RegistrationFormVariant",
                value: (byte)11);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 3 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 5 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 6 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 8 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 9 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 10 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 12 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)0, 13 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 22 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 22 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 25 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 3 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 5 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 6 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 8 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 9 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 10 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 12 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 13 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)11, 22 });

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 11 },
                column: "DisplayOrder",
                value: (byte)12);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 11 },
                column: "DisplayOrder",
                value: (byte)9);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -6, "" },
                column: "RegistrationFormVariant",
                value: (byte)0);
        }
    }
}
