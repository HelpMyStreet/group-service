using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class CorrectSpellingOfAccommodation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 34,
                column: "FriendlyName",
                value: "Accommodation");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 64,
                column: "Name",
                value: "UKRANIAN_Accommodation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 34,
                column: "FriendlyName",
                value: "Accomodation");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 64,
                column: "Name",
                value: "UKRANIAN_Accomodation");
        }
    }
}
