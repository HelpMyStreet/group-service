using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddSupportActivitiesForAgeUKSKC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[] { -11, 7, (short)4 });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[,]
                {
                    { (short)16, "{\"SupportActivityInstructions\":16,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact Marigold Centre for the  Folkestone area on 01303 279031 or for the Deal Area contact the Deal Centre on 01304 372608 to book your meal (you provide the company, we’ll provide the food!).\"},{\"Heading\":\"Enjoy your dinner together\",\"Detail\":\"Use the details given to you to meet up at the person’s chosen mealtime ( usually between 12 noon and 1pm). Have a chat and provide some company for the person you’re joining.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk. If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)17, "{\"SupportActivityInstructions\":17,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk. If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)18, "{\"SupportActivityInstructions\":17,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)19, "{\"SupportActivityInstructions\":19,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)20, "{\"SupportActivityInstructions\":20,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us Age UK South Kent Coast\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.\"},{\"Heading\":\"Collecting the prescription\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by mailto:emailingvolunteering@ageukskc.org.uk  If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)21, "{\"SupportActivityInstructions\":21,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us Age UK South Kent Coast\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.\"},{\"Heading\":\"Purchase the shopping items\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivity",
                columns: new[] { "ID", "Name" },
                values: new object[] { 23, "MealtimeCompanion" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 16, "AgeUKSKC_MealtimeCompanion" },
                    { 17, "AgeUKSKC_MealsOnWheels" },
                    { 18, "HMS_VolunteerSupport" },
                    { 19, "AgeUKSKC_Other" },
                    { 20, "AgeUKSKC_Prescriptions" },
                    { 21, "AgeUKSKC_Shopping" }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -11, 23, (short)16 },
                    { -11, 21, (short)17 },
                    { -11, 22, (short)18 },
                    { -11, 11, (short)19 },
                    { -11, 2, (short)20 },
                    { -11, 1, (short)21 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 21 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 22 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 23 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)16);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)17);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)18);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)19);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)20);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)21);
        }
    }
}
