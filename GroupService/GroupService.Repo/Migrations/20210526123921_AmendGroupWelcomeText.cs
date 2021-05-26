using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AmendGroupWelcomeText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -10, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at <a href=\\\"mailto:northmuskham@helpmystreet.org\\\">northmuskham@helpmystreet.org</a><p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our <a href=\\\"{BaseUrl}\\request-help\\\\{EncodedGroupId}\\\">Request Help form</a> and let us know what they need.</p>\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -8, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at <a href=\\\"mailto:baldertoncs@helpmystreet.org\\\">baldertoncs@helpmystreet.org</a></p><p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our <a href=\\\"{BaseUrl}\\request-help\\\\{EncodedGroupId}\\\">Request Help form</a> and let us know what they need.</p>\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -5, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at <a href=\\\"mailto:tankersley@helpmystreet.org\\\">tankersley@helpmystreet.org</a></p><p>P.S.Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you're worried about. Complete our <a href=\\\"{BaseUrl}\\request-help\\\\{EncodedGroupId}\\\">Request Help form</a> and let us know what they need.</p>\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -1, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"<p>If you haven’t done it already, you may like to complete your online ID verification now. We’ve made it as quick and easy as possible with the help of our partner, Yoti. Click <a href=\\\"{BaseUrl}\\u0007ccount/profile?u={EncodedUserId}\\\">here</a> to launch your profile and get verified.</p><p>Most requests on our platform require ID verification to give people in need of help the confidence you are who you say you are. Some of our partner organisations may also require additional checks, if this is the case we’ll let you know when you click to accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our <a href=\\\"{BaseUrl}\\request-help\\\">Request Help form</a> and let us know what they need.\"}]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -10, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at northmuskham@helpmystreet.org<p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -8, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at baldertoncs@helpmystreet.org</p><p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -5, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at tankersley@helpmystreet.org</p><p>P.S.Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about.Complete our Request Help form and let us know what they need.</p>\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -1, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"<p>If you haven’t done it already, you may like to complete your online ID verification now. We’ve made it as quick and easy as possible with the help of our partner, Yoti. Click here to launch your profile and get verified.</p><p>Most requests on our platform require ID verification to give people in need of help the confidence you are who you say you are. Some of our partner organisations may also require additional checks, if this is the case we’ll let you know when you click to accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.\"}]");
        }
    }
}
