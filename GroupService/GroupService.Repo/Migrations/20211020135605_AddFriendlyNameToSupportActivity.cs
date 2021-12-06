using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddFriendlyNameToSupportActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FriendlyName",
                schema: "Lookup",
                table: "SupportActivity",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 1,
                column: "FriendlyName",
                value: "Shopping");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 2,
                column: "FriendlyName",
                value: "Prescriptions");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 3,
                column: "FriendlyName",
                value: "Errands");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 4,
                column: "FriendlyName",
                value: "Medical Appointment Transport");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 5,
                column: "FriendlyName",
                value: "Dog Walking");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 6,
                column: "FriendlyName",
                value: "Prepared Meal");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 7,
                column: "FriendlyName",
                value: "Friendly Chat");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 8,
                column: "FriendlyName",
                value: "Supportive Chat");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 9,
                column: "FriendlyName",
                value: "Homework");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 10,
                column: "FriendlyName",
                value: "Check In");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 11,
                column: "FriendlyName",
                value: "Other");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 12,
                column: "FriendlyName",
                value: "Face Covering");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 13,
                column: "FriendlyName",
                value: "Wellbeing Package");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 14,
                column: "FriendlyName",
                value: "Community Connector");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 15,
                column: "FriendlyName",
                value: "Cold Weather Army");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 16,
                column: "FriendlyName",
                value: "Transport");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 21,
                column: "FriendlyName",
                value: "Meals To Your Door");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 22,
                column: "FriendlyName",
                value: "Volunteer Support");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 23,
                column: "FriendlyName",
                value: "Mealtime Companion");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 24,
                column: "FriendlyName",
                value: "Vaccine Support");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 25,
                column: "FriendlyName",
                value: "Emergency Support");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 26,
                column: "FriendlyName",
                value: "In-Person Befriending");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 27,
                column: "FriendlyName",
                value: "Practical Support");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 28,
                column: "FriendlyName",
                value: "Volunteer Induction");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 29,
                column: "FriendlyName",
                value: "Digital Support");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 30,
                column: "FriendlyName",
                value: "Bin Day Assistance");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 31,
                column: "FriendlyName",
                value: "Covid 19 Help");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 32,
                column: "FriendlyName",
                value: "Bank Staff Vaccinator");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 33,
                column: "FriendlyName",
                value: "Skill Share");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FriendlyName",
                schema: "Lookup",
                table: "SupportActivity");
        }
    }
}
