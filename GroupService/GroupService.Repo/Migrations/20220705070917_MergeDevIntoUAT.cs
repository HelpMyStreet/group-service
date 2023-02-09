using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class MergeDevIntoUAT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CommunicationJobType",
                columns: new[] { "ID", "Name" },
                values: new object[] { 20, "ImpendingUserDeletion" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CommunicationJobType",
                columns: new[] { "ID", "Name" },
                values: new object[] { 21, "UserDeleted" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "CommunicationJobType",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "CommunicationJobType",
                keyColumn: "ID",
                keyValue: 21);
        }
    }
}
