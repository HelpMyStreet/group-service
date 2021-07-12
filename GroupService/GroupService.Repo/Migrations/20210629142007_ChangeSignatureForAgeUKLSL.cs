using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ChangeSignatureForAgeUKLSL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -3, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:volunteering@ageuklsl.org.uk\\\">volunteering@ageuklsl.org.uk</a>.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Pip\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:volunteering@ageuklsl.org.uk\\\">volunteering@ageuklsl.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -3, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:volunteering@ageuklsl.org.uk\\\">volunteering@ageuklsl.org.uk</a>.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK Lincoln & South Lincolnshire\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:volunteering@ageuklsl.org.uk\\\">volunteering@ageuklsl.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");
        }
    }
}
