using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddShortNamesForGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -32,
                column: "ShortName",
                value: "Apex Bank Staff");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23,
                column: "ShortName",
                value: "Age Connects Cardiff");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -13,
                column: "ShortName",
                value: "Faversham & Sittingbourne");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                column: "ShortName",
                value: "Lincs Vols");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -11,
                column: "ShortName",
                value: "South Kent Coast");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -10,
                column: "ShortName",
                value: "North Muskham");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -9,
                column: "ShortName",
                value: "Age UK NW Kent");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -7,
                column: "ShortName",
                value: "Wirral");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -2,
                column: "ShortName",
                value: "FTLOS");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -1,
                column: "ShortName",
                value: "HelpMyStreet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: -7,
                column: "ShortName",
                value: "Age UK Wirral");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -2,
                column: "ShortName",
                value: "For the Love of Scrubs");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -1,
                column: "ShortName",
                value: null);
        }
    }
}
