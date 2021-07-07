using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddApexPCNLogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -20, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -20, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"False\"}]");
        }
    }
}
