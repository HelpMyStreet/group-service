using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class GPS386MealsOnWheelsRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 21,
                column: "Name",
                value: "MealsToYourDoor");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 17,
                column: "Name",
                value: "AgeUKSKC_MealsToYourDoor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 21,
                column: "Name",
                value: "MealsOnWheels");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 17,
                column: "Name",
                value: "AgeUKSKC_MealsOnWheels");
        }
    }
}
