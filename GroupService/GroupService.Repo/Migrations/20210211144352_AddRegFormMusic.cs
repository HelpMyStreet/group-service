using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddRegFormMusic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.EnsureSchema(
                name: "Configuration");

            migrationBuilder.CreateTable(
                name: "SupportActivity",
                schema: "Configuration",
                columns: table => new
                {
                    SupportActivityID = table.Column<int>(nullable: false),
                    AutoSignUpWhenOtherSelected = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportActivity", x => x.SupportActivityID);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationFormSupportActivity",
                schema: "Website",
                columns: table => new
                {
                    RequestHelpFormVariantID = table.Column<byte>(nullable: false),
                    SupportActivityID = table.Column<int>(nullable: false),
                    Label = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    DisplayOrder = table.Column<byte>(nullable: false),
                    IsPreSelected = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationFormSupportActivity", x => new { x.RequestHelpFormVariantID, x.SupportActivityID });
                });

            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "SupportActivity",
                columns: new[] { "SupportActivityID", "AutoSignUpWhenOtherSelected" },
                values: new object[,]
                {
                    { 24, true },
                    { 22, true },
                    { 21, true },
                    { 15, true },
                    { 13, true },
                    { 10, true },
                    { 7, true },
                    { 6, true },
                    { 5, true },
                    { 3, true },
                    { 2, true },
                    { 1, true },
                    { 23, true }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                columns: new[] { "RequestHelpFormVariantID", "SupportActivityID", "DisplayOrder", "IsPreSelected", "Label" },
                values: new object[,]
                {
                    { (byte)5, 11, (byte)9, false, "I may be able to help with other tasks, so please check with me." },
                    { (byte)5, 7, (byte)7, false, "Calling someone in need of a friendly chat" },
                    { (byte)5, 5, (byte)6, false, "Walking the dog" },
                    { (byte)5, 3, (byte)5, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)5, 16, (byte)4, false, "Providing transport for essential appointments" },
                    { (byte)5, 15, (byte)3, false, "Providing help in emergency situations during a cold snap" },
                    { (byte)5, 2, (byte)2, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)5, 1, (byte)1, false, "Picking up groceries and other essentials (e.g. food, toiletries, household products etc.)" },
                    { (byte)3, 13, (byte)1, true, "Collecting and delivering a pre-prepared wellbeing package" },
                    { (byte)4, 12, (byte)1, true, "Supplying homemade face coverings" },
                    { (byte)2, 12, (byte)1, true, "Supplying reusable homemade face coverings through For the Love of Scrubs" },
                    { (byte)5, 8, (byte)8, false, "Providing support over the phone to someone who may be anxious (relevant experience required e.g. mental health first-aider)" },
                    { (byte)1, 14, (byte)1, true, "Being a <strong>COMMUNITY CONNECTOR</strong" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportActivity",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "RegistrationFormSupportActivity",
                schema: "Website");

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivity",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 17, "FrontOfHouseAdmin" },
                    { 18, "BackOfficeAdmin" },
                    { 19, "HealthcareAssistant" },
                    { 20, "Steward" }
                });
        }
    }
}
