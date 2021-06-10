using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddApexBankStaff_SupportActivityInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[] { -32, 11, (short)2 });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[] { (short)56, "{\"SupportActivityInstructions\":56,\"ActivityDetails\":\"This is a paid role. Registered vaccinators are required for the local COVID-19 vaccination site at Ruston Sports and Social Club, Lincoln. Patients from all five APEX PCN member practices attend the site which has a current footfall in excess of 1301 patients per day. We run two four - hour shifts per day.Vaccinators are welcome to book onto a morning and an afternoon shift on the same day. Before you first shift you will be offered a full induction supported by the centre manager, current vaccinators and advanced practitioners.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Accept the shift\",\"Detail\":\"To book onto a shift simply click the green button below. We run two shifts per day and welcome staff wishing to book onto both shifts. You will find all our open shifts in 'Open Shifts'.\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"You'll receive a reminder email the day before your shift. Once you've completed a shift it will be marked as complete automatically, but you can still view a completed shift by selecting shifts with the status 'Done' in 'My Shifts'.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer.On rare occasions we may need to cancela shift at short notice, where this is the case we will update you by email and endeavour to contact you using the details provided in your profile.\"}" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[] { 56, "APEXBank_BankStaffVaccinator" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[] { -32, 32, (short)56 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -32, 11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -32, 32 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)56);
        }
    }
}
