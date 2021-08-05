using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AgeUKMMActivities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -33, 10, 20.0, (short)6 },
                    { -33, 7, 2000.0, (short)4 },
                    { -33, 30, 20.0, (short)3 },
                    { -33, 15, 20.0, (short)3 },
                    { -33, 31, 20.0, (short)3 },
                    { -33, 29, 20.0, (short)3 },
                    { -33, 5, 20.0, (short)3 },
                    { -33, 2, 20.0, (short)2 },
                    { -33, 3, 20.0, (short)2 },
                    { -33, 11, 20.0, (short)2 },
                    { -33, 27, 20.0, (short)2 },
                    { -33, 1, 20.0, (short)1 },
                    { -33, 33, 20.0, (short)18 },
                    { -33, 22, 20.0, (short)18 },
                    { -33, 13, 20.0, (short)18 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[] { (short)58, "{\"SupportActivityInstructions\":58,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Arrange a visit\",\"Detail\":\"Give them a call to arrange a visit – find a time and a place that suits you both.\"},{\"Heading\":\"Enjoy your visit\",\"Detail\":\"Meet up as agreed and have a good chat. If it’s going well, you could arrange your next visit too!\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[] { -33, 26, 20.0, (short)58 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 3 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 5 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 10 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 13 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 22 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 26 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 27 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 29 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 30 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 31 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -33, 33 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)58);
        }
    }
}
