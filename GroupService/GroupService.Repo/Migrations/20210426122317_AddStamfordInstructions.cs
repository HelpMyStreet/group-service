using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddStamfordInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)22,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":22,\"ActivityDetails\":\"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. Duties may vary by location and could include a range of indoor or outdoor activities, such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site, general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept this role and basic training will be provided on the day. For a fuller description please see the volunteer instructions which are available when you click to accept the shift or by clicking “View more info” on accepted shifts in the “My Shifts” tab.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Please read the [role description and useful information](/pdf/lincs-vaccination-support/lincs-vaccination-support-role-description.pdf) attachment for full details of the role.\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather (e.g. a warm / waterproof coat). Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the details in the “My Shifts” tab but searching for shifts with the status “Done”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer.\"}");

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[] { (short)53, "{\"SupportActivityInstructions\":53,\"ActivityDetails\":\"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. Duties may vary by location and could include a range of indoor or outdoor activities, such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site, general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept this role and basic training will be provided on the day. For a fuller description please see the volunteer instructions which are available when you click to accept the shift or by clicking “View more info” on accepted shifts in the “My Shifts” tab.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Please read the [role description and useful information](/pdf/lincs-vaccination-support/outdoor-volunteer-role-description-pcn-four-counties.pdf) attachment for full details of the role. Volunteers may also be asked to participate in regular lateral flow testing, you can find more information [here](/pdf/lincs-vaccination-support/lateral-flow-testing-for-vaccination-support-volunteers.pdf).\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather (e.g. a warm / waterproof coat). On your first shift at St. Mary’s please also bring some photo ID so we can take a copy for our records. Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the details in the “My Shifts” tab but searching for shifts with the status “Done”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer.\"}" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[] { 53, "Lincoln_Stamford_VaccineSupport" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -17, 24 },
                column: "SupportActivityInstructionsID",
                value: (short)53);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -17, 24 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)53);

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[] { -17, 24, (short)22 });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)22,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":22,\"ActivityDetails\":\"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. Duties may vary by location and could include a range of indoor or outdoor activities, such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site, general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept this role and basic training will be provided on the day. For a fuller description please see the volunteer instructions which are available when you click to accept the shift or by clicking “View more info” on accepted shifts in the “My Shifts” tab.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Please read the [role description and useful information](/pdf/lincs-vaccination-support/lincs-vaccination-support-role-description.pdf) attachment for full details of the role.\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather (e.g. a warm / waterproof coat). Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the details in the “My Shifts” tab but searching for shifts with the status “Done”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }
    }
}
