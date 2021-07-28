using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AgeUKMMEmails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[] { -33, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href='mailto:enquiries@aukmm.org.uk'>enquiries@aukmm.org.uk</a></p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>The Age UK Mid Mersey team\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href='mailto:enquiries@aukmm.org.uk'>enquiries@aukmm.org.uk</a>\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -33, (byte)15 });
        }
    }
}
