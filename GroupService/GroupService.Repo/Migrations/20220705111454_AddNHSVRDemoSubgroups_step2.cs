using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddNHSVRDemoSubgroups_step2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[,]
                {
                    { -39, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p><p>For some roles, we may also require additional checks or training – we will let you know if any additional checks are needed before you accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:contact@helpmystreet.org\\\">contact@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -40, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p><p>For some roles, we may also require additional checks or training – we will let you know if any additional checks are needed before you accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:contact@helpmystreet.org\\\">contact@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupLocation",
                columns: new[] { "GroupID", "LocationID" },
                values: new object[,]
                {
                    { -39, -15 },
                    { -39, -13 },
                    { -39, -11 },
                    { -40, -15 },
                    { -40, -13 },
                    { -40, -11 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                columns: new[] { "GroupID", "MaxVolunteer", "NewRequestNotificationStrategyId" },
                values: new object[,]
                {
                    { -39, 2147483647, (byte)1 },
                    { -40, 2147483647, (byte)1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -40, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -39, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -40, -15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -40, -13 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -40, -11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -39, -15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -39, -13 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -39, -11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -40);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -39);
        }
    }
}
