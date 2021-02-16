using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddRegFormMusicForRemainingVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 14 },
                column: "Label",
                value: "Being a **COMMUNITY CONNECTOR**");

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                columns: new[] { "RequestHelpFormVariantID", "SupportActivityID", "DisplayOrder", "IsPreSelected", "Label" },
                values: new object[,]
                {
                    { (byte)7, 11, (byte)6, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)7, 7, (byte)5, false, "A friendly chat on the phone" },
                    { (byte)7, 2, (byte)4, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)7, 22, (byte)3, false, "Helping with events, admin duties or not-for-profit activities" },
                    { (byte)7, 16, (byte)2, false, "Providing transport for essential appointments" },
                    { (byte)7, 21, (byte)1, false, "Delivering freshly prepared meal straight to someone’s door" },
                    { (byte)6, 11, (byte)8, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)8, 1, (byte)1, false, "Picking up groceries and other essentials" },
                    { (byte)6, 10, (byte)7, false, "Reaching out to people in my area to check-in" },
                    { (byte)6, 6, (byte)5, false, "Preparing and/or delivering a hot / pre-prepared meal" },
                    { (byte)6, 5, (byte)4, false, "Walking a calm dog" },
                    { (byte)6, 3, (byte)3, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)6, 2, (byte)2, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)6, 1, (byte)1, false, "Picking up groceries and other essentials" },
                    { (byte)3, 11, (byte)12, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)3, 10, (byte)11, false, "Reaching out to people in my area to check-in" },
                    { (byte)6, 7, (byte)6, false, "A friendly chat on the phone" },
                    { (byte)8, 2, (byte)2, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)8, 7, (byte)3, false, "A friendly chat on the phone" },
                    { (byte)8, 23, (byte)4, false, "Providing company over a mealtime for someone who lives alone" },
                    { (byte)10, 16, (byte)8, false, "Providing transport for essential appointments" },
                    { (byte)10, 10, (byte)7, false, "Reaching out to people in my area to check-in" },
                    { (byte)10, 7, (byte)6, false, "A friendly chat on the phone" },
                    { (byte)10, 6, (byte)5, false, "Preparing and/or delivering a hot / pre-prepared meal" },
                    { (byte)10, 3, (byte)4, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)10, 2, (byte)3, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)10, 1, (byte)2, false, "Picking up groceries and other essentials (e.g. food, toiletries, household products)" },
                    { (byte)10, 24, (byte)1, true, "Volunteering to support the COVID-19 vaccination programme (e.g. support staff for local vaccination centres)" },
                    { (byte)9, 11, (byte)6, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)9, 22, (byte)5, false, "Helping with events, admin duties or not-for-profit activities" },
                    { (byte)9, 16, (byte)4, false, "Providing transport for essential appointments" },
                    { (byte)9, 21, (byte)3, false, "Delivering a freshly prepared meal straight to someone’s door" },
                    { (byte)9, 23, (byte)2, false, "Providing company over a mealtime for someone who lives alone" },
                    { (byte)9, 7, (byte)1, false, "A friendly chat on the phone" },
                    { (byte)8, 11, (byte)7, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)8, 22, (byte)6, false, "Helping with events, admin duties or not-for-profit activities" },
                    { (byte)8, 21, (byte)5, false, "Delivering a freshly prepared meal straight to someone’s door" },
                    { (byte)3, 9, (byte)10, false, "Providing remote support for parents and carers home-schooling their children" },
                    { (byte)3, 8, (byte)9, false, "Providing support over the phone to someone who may be anxious (relevant experience required e.g. mental health first-aider)" },
                    { (byte)3, 7, (byte)8, false, "Calling someone in need of a friendly chat" },
                    { (byte)3, 6, (byte)7, false, "Preparing and/or delivering a hot / pre-prepared meal" },
                    { (byte)2, 6, (byte)7, false, "Preparing and/or delivering a hot / pre-prepared meal" },
                    { (byte)2, 5, (byte)6, false, "Walking the dog" },
                    { (byte)2, 13, (byte)5, false, "Collecting and delivering a pre-prepared wellbeing package" },
                    { (byte)2, 3, (byte)4, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)2, 2, (byte)3, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)2, 1, (byte)2, false, "Picking up groceries and other essentials (e.g. food, toiletries, household products etc.)" },
                    { (byte)1, 11, (byte)13, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)1, 10, (byte)12, false, "Reaching out to people in my area to check-in" },
                    { (byte)1, 9, (byte)11, false, "Providing remote support for parents and carers home-schooling their children" },
                    { (byte)1, 8, (byte)10, false, "Providing support over the phone to someone who may be anxious (relevant experience required e.g. mental health first-aider)" },
                    { (byte)1, 7, (byte)9, false, "Calling someone in need of a friendly chat" },
                    { (byte)1, 6, (byte)8, false, "Preparing and/or delivering a hot / pre-prepared meal" },
                    { (byte)1, 5, (byte)7, false, "Walking the dog" },
                    { (byte)1, 13, (byte)6, false, "Collecting and delivering a pre-prepared wellbeing package" },
                    { (byte)1, 3, (byte)5, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)1, 2, (byte)4, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)1, 12, (byte)3, false, "Supplying homemade face coverings" },
                    { (byte)2, 7, (byte)8, false, "Calling someone in need of a friendly chat" },
                    { (byte)10, 11, (byte)9, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)2, 8, (byte)9, false, "Providing support over the phone to someone who may be anxious (relevant experience required e.g. mental health first-aider)" },
                    { (byte)2, 10, (byte)11, false, "Reaching out to people in my area to check-in" },
                    { (byte)3, 5, (byte)6, false, "Walking the dog" },
                    { (byte)3, 3, (byte)5, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)3, 2, (byte)4, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)3, 12, (byte)3, false, "Supplying homemade face coverings" },
                    { (byte)3, 1, (byte)2, false, "Picking up groceries and other essentials (e.g. food, toiletries, household products etc.)" },
                    { (byte)4, 11, (byte)12, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)4, 10, (byte)11, false, "Reaching out to people in my area to check-in" },
                    { (byte)4, 9, (byte)10, false, "Providing remote support for parents and carers home-schooling their children" },
                    { (byte)4, 8, (byte)9, false, "Providing support over the phone to someone who may be anxious (relevant experience required e.g. mental health first-aider)" },
                    { (byte)4, 7, (byte)8, false, "Calling someone in need of a friendly chat" },
                    { (byte)4, 6, (byte)7, false, "Preparing and/or delivering a hot / pre-prepared meal" },
                    { (byte)4, 5, (byte)6, false, "Walking the dog" },
                    { (byte)4, 13, (byte)5, false, "Collecting and delivering a pre-prepared wellbeing package" },
                    { (byte)4, 3, (byte)4, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)4, 2, (byte)3, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)4, 1, (byte)2, false, "Picking up groceries and other essentials (e.g. food, toiletries, household products etc.)" },
                    { (byte)2, 11, (byte)12, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)2, 9, (byte)10, false, "Providing remote support for parents and carers home-schooling their children" },
                    { (byte)1, 1, (byte)2, false, "Picking up groceries and other essentials (e.g. food, toiletries, household products etc.)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 3 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 5 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 6 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 8 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 9 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 10 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 12 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 13 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 3 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 5 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 6 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 8 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 9 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 10 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)2, 13 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 3 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 5 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 6 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 8 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 9 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 10 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)3, 12 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 3 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 5 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 6 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 8 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 9 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 10 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)4, 13 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)6, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)6, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)6, 3 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)6, 5 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)6, 6 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)6, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)6, 10 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)6, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)7, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)7, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)7, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)7, 16 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)7, 21 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)7, 22 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)8, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)8, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)8, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)8, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)8, 21 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)8, 22 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)8, 23 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)9, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)9, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)9, 16 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)9, 21 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)9, 22 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)9, 23 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 3 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 6 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 7 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 10 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 16 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)10, 24 });

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)1, 14 },
                column: "Label",
                value: "Being a <strong>COMMUNITY CONNECTOR</strong");
        }
    }
}
