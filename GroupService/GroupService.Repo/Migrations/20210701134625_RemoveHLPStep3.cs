using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveHLPStep3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -4, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -4, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "FriendlyName", "GeographicName", "GroupKey", "GroupName", "GroupType", "HomepageEnabled", "JoinGroupPopUpDetail", "LinkURL", "ParentGroupId", "ShiftsEnabled", "ShortName", "TasksEnabled" },
                values: new object[] { -4, "Healthy London Partnership", null, "hlp", "Healthy London Partnership", (byte)0, true, null, "/healthylondonpartnership", null, false, "Healthy London", true });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[] { -4, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Healthy London Partnership\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupMapDetails",
                columns: new[] { "GroupID", "MapLocationID", "Latitude", "Longitude", "ZoomLevel" },
                values: new object[] { -4, (byte)0, 51.507602m, -0.127816m, 10m });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                columns: new[] { "GroupID", "MaxVolunteer", "NewRequestNotificationStrategyId" },
                values: new object[] { -4, 2147483647, (byte)1 });
        }
    }
}
