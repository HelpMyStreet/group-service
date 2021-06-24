using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddGeographicName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GeographicName",
                schema: "Group",
                table: "Group",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -31,
                column: "GeographicName",
                value: "Southwell or surrounding areas");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -24,
                column: "GeographicName",
                value: "The Meadows");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23,
                column: "GeographicName",
                value: "Cardiff & the Vale");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -13,
                column: "GeographicName",
                value: "Faversham or Sittingbourne");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -11,
                column: "GeographicName",
                value: "Deal or Folkestone");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -10,
                column: "GeographicName",
                value: "North Muskham");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -9,
                column: "GeographicName",
                value: "North West Kent (Dartford, Swanley or Gravesend)");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8,
                column: "GeographicName",
                value: "Balderton");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -6,
                column: "GeographicName",
                value: "Ruddington");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -14, 24 },
                column: "SupportActivityInstructionsID",
                value: (short)55);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GeographicName",
                schema: "Group",
                table: "Group");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -14, 24 },
                column: "SupportActivityInstructionsID",
                value: (short)22);
        }
    }
}
