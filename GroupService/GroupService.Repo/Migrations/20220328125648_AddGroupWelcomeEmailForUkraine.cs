using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddGroupWelcomeEmailForUkraine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[] { -35, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>HelpMyStreet is being made available to help prospective UK hosts find a suitable match for the UK Government Homes for Ukraine Scheme. If you find a suitable person / family on HelpMyStreet you will need to submit a separate application through the UK Government Homes for Ukraine Scheme to start the official process.</p><p>HelpMyStreet will be partnering with organisations and individuals who have experience with finding accommodation for people fleeing unsafe situations. Each partner will be able to bring their own processes for vetting hosts and those requesting help.</p><p>You are registering as a host. As a minimum you will need to verify your identity online using photographic ID. Some referring organisations may require additional checks - if these apply you’ll be shown the relevant details when you click to accept a request.</p><p>Many people fleeing Ukraine have some preference for where they are placed to make sure they are close to family, friends, or their wider community. This is important to make sure they are settled and supported in their new community. Our platform will notify you when new requests are submitted for accommodation in your area. If you have also expressed an interest in other volunteering activities the HelpMyStreet platform may also email you about other opportunities in your area.<p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Thank you for your offer of support,</p><p>From all at HelpMyStreet and our partners\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" });            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -35, (byte)15 });            
        }
    }
}
