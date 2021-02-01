using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddShiftEnabledFlagForPCN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -21,
                column: "ShiftsEnabled",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -20,
                column: "ShiftsEnabled",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -19,
                column: "ShiftsEnabled",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -18,
                column: "ShiftsEnabled",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -17,
                column: "ShiftsEnabled",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -16,
                column: "ShiftsEnabled",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -15,
                column: "ShiftsEnabled",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -14,
                column: "ShiftsEnabled",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                column: "ShiftsEnabled",
                value: true);

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 32, "AgeUKFANDS_Other" },
                    { 30, "AgeUKFANDS_Transport" },
                    { 29, "AgeUKFANDS_MealtimeCompanion" },
                    { 28, "AgeUKFANDS_MealsToYourDoor" },
                    { 27, "AgeUKFANDS_FriendlyChat" },
                    { 26, "AgeUKNWK_Shopping" },
                    { 25, "AgeUKNWK_Prescriptions" },
                    { 24, "AgeUKNWK_Other" },
                    { 31, "AgeUKFANDS_VolunteerSupport" },
                    { 23, "AgeUKNWK_MealsToYourDoor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -21,
                column: "ShiftsEnabled",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -20,
                column: "ShiftsEnabled",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -19,
                column: "ShiftsEnabled",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -18,
                column: "ShiftsEnabled",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -17,
                column: "ShiftsEnabled",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -16,
                column: "ShiftsEnabled",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -15,
                column: "ShiftsEnabled",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -14,
                column: "ShiftsEnabled",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                column: "ShiftsEnabled",
                value: false);
        }
    }
}
