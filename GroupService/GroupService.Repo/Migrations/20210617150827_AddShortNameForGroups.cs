using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddShortNameForGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                schema: "Group",
                table: "Group",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -32,
                column: "ShortName",
                value: "Apex PCN Bank Staff");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -31,
                column: "ShortName",
                value: "Southwell");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -24,
                column: "ShortName",
                value: "Meadows");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23,
                column: "ShortName",
                value: "Age Connect Cardiff");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -13,
                column: "ShortName",
                value: "Age UK Faversham");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                column: "ShortName",
                value: "Linc Volunteers");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -11,
                column: "ShortName",
                value: "Age UK SKC");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -10,
                column: "ShortName",
                value: "Age UK Muskham");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -9,
                column: "ShortName",
                value: "Age UK NWK");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8,
                column: "ShortName",
                value: "Balderton");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -7,
                column: "ShortName",
                value: "Age UK Wirral");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -6,
                column: "ShortName",
                value: "Ruddington");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -5,
                column: "ShortName",
                value: "Tankersley");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -4,
                column: "ShortName",
                value: "Healthy London");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -3,
                column: "ShortName",
                value: "Age UK LSL");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -2,
                column: "ShortName",
                value: "For the Love of Scrubs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortName",
                schema: "Group",
                table: "Group");
        }
    }
}
