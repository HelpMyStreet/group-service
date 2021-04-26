using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class SupportActivityInstructionsStep1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[,]
                {
                    { (short)51, "{\"SupportActivityInstructions\":51,\"ActivityDetails\":null,\"Intro\":\"Please follow these steps to complete this request. You can also find more guidance for telephone befriending [here](/pdf/notts/northmuskham/TelephoneBefriending.pdf).\",\"Steps\":[{\"Heading\":\"Give them a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)49, "{\"SupportActivityInstructions\":49,\"ActivityDetails\":null,\"Intro\":\"Please follow these steps to complete this request. You can also find more guidance for shopping volunteers [here](/pdf/notts/northmuskham/Shopping.pdf).\",\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Pick up their shopping and drop it off at their door. Make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their shopping.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)47, "{\"SupportActivityInstructions\":47,\"ActivityDetails\":null,\"Intro\":\"Please follow these steps to complete this request. You can also find more guidance for telephone befriending [here](/pdf/notts/balderton/TelephoneBefriending.pdf).\",\"Steps\":[{\"Heading\":\"Give them a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)46, "{\"SupportActivityInstructions\":46,\"ActivityDetails\":null,\"Intro\":\"Please follow these steps to complete this request. You can also find more guidance for prescription collection volunteers [here](/pdf/notts/balderton/PrescriptionCollection.pdf).\",\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)45, "{\"SupportActivityInstructions\":45,\"ActivityDetails\":null,\"Intro\":\"Please follow these steps to complete this request. You can also find more guidance for shopping volunteers [here](/pdf/notts/balderton/Shopping.pdf).\",\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Pick up their shopping and drop it off at their door. Make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their shopping.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)52, "{\"SupportActivityInstructions\":52,\"ActivityDetails\":null,\"Intro\":\"Please follow these steps to complete this request. You can also find more guidance for dog walking volunteers [here](/pdf/notts/northmuskham/DogWalking.pdf).\",\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Get in touch with the person who needs the help to confirm what they need. If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that’s needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)48, "{\"SupportActivityInstructions\":48,\"ActivityDetails\":null,\"Intro\":\"Please follow these steps to complete this request. You can also find more guidance for dog walking volunteers [here](/pdf/notts/balderton/DogWalking.pdf).\",\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Get in touch with the person who needs the help to confirm what they need. If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that’s needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)50, "{\"SupportActivityInstructions\":50,\"ActivityDetails\":null,\"Intro\":\"Please follow these steps to complete this request. You can also find more guidance for prescription collection volunteers [here](/pdf/notts/northmuskham/PrescriptionCollection.pdf).\",\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 52, "AgeUKNottsNorthMuskham_DogWalking" },
                    { 51, "AgeUKNottsNorthMuskham_FriendlyChat" },
                    { 49, "AgeUKNottsNorthMuskham_Shopping" },
                    { 48, "AgeUKNottsBalderton_DogWalking" },
                    { 47, "AgeUKNottsBalderton_FriendlyChat" },
                    { 46, "AgeUKNottsBalderton_Prescriptions" },
                    { 45, "AgeUKNottsBalderton_Shopping" },
                    { 50, "AgeUKNottsNorthMuskham_Prescriptions" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)45);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)46);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)47);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)48);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)49);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)50);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)51);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)52);
            
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 52);
        }
    }
}
