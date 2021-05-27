using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class CreateSouthwell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "GroupKey", "GroupName", "HomepageEnabled", "ParentGroupId", "ShiftsEnabled", "TasksEnabled" },
                values: new object[] { -31, "southwell", "Southwell Torpedos", true, null, false, true });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 15, "Southwell" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 25, "Soutwell_Public" });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                columns: new[] { "RequestHelpFormVariantID", "SupportActivityID", "DisplayOrder", "IsPreSelected", "Label" },
                values: new object[,]
                {
                    { (byte)15, 1, (byte)1, false, "Picking up groceries and other essentials (e.g. food, toiletries, household products etc.)" },
                    { (byte)15, 2, (byte)2, false, "Collecting prescriptions from a local pharmacy" },
                    { (byte)15, 3, (byte)3, false, "Running essential local errands (e.g. posting mail)" },
                    { (byte)15, 30, (byte)4, false, "Taking out the bins on bin day" },
                    { (byte)15, 11, (byte)5, false, "I may be able to help with other tasks, so please check with me." }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -31, 1, (short)1 },
                    { -31, 2, (short)2 },
                    { -31, 11, (short)2 }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant" },
                values: new object[] { -31, "", (byte)15 });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "SuppressRecipientPersonalDetails", "TargetGroups" },
                values: new object[] { -31, "a", true, (byte)25, false, false, false, (byte)4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -31, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -31, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -31, 11 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)15, 1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)15, 2 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)15, 3 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)15, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)15, 30 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -31, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -31, "a" });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -31);
        }
    }
}
