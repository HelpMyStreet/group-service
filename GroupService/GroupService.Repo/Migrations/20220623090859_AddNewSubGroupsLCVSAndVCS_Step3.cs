using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddNewSubGroupsLCVSAndVCS_Step3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[] { (short)65, "{\"SupportActivityInstructions\":65,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the opportunity is right for you\",\"Detail\":\"Make sure you’ve clicked to ‘view more info’ on the open request to check the opportunity is right for you.\"},{\"Heading\":\"Click to apply\",\"Detail\":\"If you want to find out or apply for the role, click to apply. The organisation managing the request will be in touch to take you through the next steps.\"},{\"Heading\":\"Start helping\",\"Detail\":\"Once everything is in place you can start helping! The request will stay in your “My Requests” view for as long as you’re helping.\"}],\"Close\":\"In your “My Requests” view you can mark the request as complete or let the requester know you can no longer help by clicking “Can’t Do” so they can’t start looking for a new volunteer.\"}" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[] { 65, "Lincolnshire_AdvertisingRoles" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[] { -36, 35, 20.0, (short)65 });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[] { -37, 35, 20.0, (short)65 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -37, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -36, 35 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)65);
        }
    }
}
