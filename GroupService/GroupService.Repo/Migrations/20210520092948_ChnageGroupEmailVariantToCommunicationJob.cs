using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ChnageGroupEmailVariantToCommunicationJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupEmailVariant",
                schema: "Lookup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupEmailConfiguration",
                schema: "Group",
                table: "GroupEmailConfiguration");

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -24, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -23, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -22, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -20, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -17, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -13, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -12, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -11, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -10, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -9, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -8, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -7, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -6, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -5, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -4, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -3, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -2, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "GroupEmailVariantID" },
                keyValues: new object[] { -1, (byte)1 });

            migrationBuilder.DropColumn(
                name: "GroupEmailVariantID",
                schema: "Group",
                table: "GroupEmailConfiguration");

            migrationBuilder.AddColumn<byte>(
                name: "CommunicationJobTypeID",
                schema: "Group",
                table: "GroupEmailConfiguration",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupEmailConfiguration",
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID" });

            migrationBuilder.CreateTable(
                name: "CommunicationJobType",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationJobType", x => x.ID);
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[,]
                {
                    { -2, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"1\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -22, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -20, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -17, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -13, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -12, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -11, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -10, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at northmuskham@helpmystreet.org<p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>\"}]" },
                    { -9, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -8, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at baldertoncs@helpmystreet.org</p><p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>\"}]" },
                    { -7, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -6, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -5, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at tankersley@helpmystreet.org</p><p>P.S.Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about.Complete our Request Help form and let us know what they need.</p>\"}]" },
                    { -4, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"1\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -3, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -23, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -24, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -1, (byte)15, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"<p>If you haven’t done it already, you may like to complete your online ID verification now. We’ve made it as quick and easy as possible with the help of our partner, Yoti. Click here to launch your profile and get verified.</p><p>Most requests on our platform require ID verification to give people in need of help the confidence you are who you say you are. Some of our partner organisations may also require additional checks, if this is the case we’ll let you know when you click to accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.\"}]" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CommunicationJobType",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 15, "GroupWelcome" },
                    { 14, "SendShiftReminder" },
                    { 13, "SendNewRequestNotification" },
                    { 12, "TaskDetail" },
                    { 11, "RequestorTaskConfirmation" },
                    { 10, "NewTaskPendingApprovalNotification" },
                    { 9, "NewCredentials" },
                    { 8, "InterUserMessage" },
                    { 7, "SendTaskReminder" },
                    { 6, "PostYotiCommunication" },
                    { 5, "SendTaskStateChangeUpdate" },
                    { 4, "SendOpenTaskDigest" },
                    { 3, "SendNewTaskNotification" },
                    { 2, "SendRegistrationChasers" },
                    { 1, "SendWelcomeMessage" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommunicationJobType",
                schema: "Lookup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupEmailConfiguration",
                schema: "Group",
                table: "GroupEmailConfiguration");

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -24, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -22, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -20, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -17, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -13, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -12, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -11, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -10, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -9, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -8, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -7, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -6, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -5, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -4, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -3, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -2, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -1, (byte)15 });

            migrationBuilder.DropColumn(
                name: "CommunicationJobTypeID",
                schema: "Group",
                table: "GroupEmailConfiguration");

            migrationBuilder.AddColumn<byte>(
                name: "GroupEmailVariantID",
                schema: "Group",
                table: "GroupEmailConfiguration",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupEmailConfiguration",
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "GroupEmailVariantID" });

            migrationBuilder.CreateTable(
                name: "GroupEmailVariant",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupEmailVariant", x => x.ID);
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "GroupEmailVariantID", "Configuration" },
                values: new object[,]
                {
                    { -9, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -22, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -20, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -17, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -13, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -12, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -11, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -10, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at northmuskham@helpmystreet.org<p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>\"}]" },
                    { -23, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -24, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -7, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -6, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -5, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at tankersley@helpmystreet.org</p><p>P.S.Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about.Complete our Request Help form and let us know what they need.</p>\"}]" },
                    { -4, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"1\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -3, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -2, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"1\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -1, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"<p>If you haven’t done it already, you may like to complete your online ID verification now. We’ve made it as quick and easy as possible with the help of our partner, Yoti. Click here to launch your profile and get verified.</p><p>Most requests on our platform require ID verification to give people in need of help the confidence you are who you say you are. Some of our partner organisations may also require additional checks, if this is the case we’ll let you know when you click to accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.\"}]" },
                    { -8, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at baldertoncs@helpmystreet.org</p><p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>\"}]" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "GroupEmailVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Welcome" });
        }
    }
}
