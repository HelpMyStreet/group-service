using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class DisableCardiffPublicForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -32, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>We are using HelpMyStreet to coordinate our bank shifts. To book onto a shift you will need to have met the essential criteria for the role. If there is something missing from your profile we will let you know when you try to book onto a shift. Please be aware that shifts may be added or cancelled at short notice due to unexpected demand. </p><p>HelpMyStreet was originally built for volunteering so please be aware that there may be some unpaid volunteer roles advertised on the platform. All of our roles will specify where they are paid positions.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Kind regards,</p><p>Gary Burroughs - PCN Manager\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -23, "" },
                column: "AccessRestrictedByRole",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -32, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>We are using HelpMyStreet to coordinate our bank shifts. To book onto a shift you will need to have met the essential criteria for the role. If there is something missing from your profile we will let you know when you try to book onto a shift.Please be aware that shifts may be added or cancelled at short notice due to unexpected demand. </p><p>HelpMyStreet was originally built for volunteering so please be aware that there may be some unpaid volunteer roles advertised on the platform. All of our roles will specify where they are paid positions.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Kind regards,</p><p>Gary Burroughs - PCN Manager\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -23, "" },
                column: "AccessRestrictedByRole",
                value: false);
        }
    }
}
