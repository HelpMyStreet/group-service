using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddGroupLogoForAgeConnectsCardiff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"GroupLogo\",\"Value\":\"ageconnectcardifflogo.png\"}]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");
        }
    }
}
