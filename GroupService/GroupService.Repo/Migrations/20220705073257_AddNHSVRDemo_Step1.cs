using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddNHSVRDemo_Step1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "SupportActivity",
                columns: new[] { "SupportActivityID", "AutoSignUpWhenOtherSelected" },
                values: new object[,]
                {
                    { 36, true },
                    { 37, true },
                    { 38, true },
                    { 39, true }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 34, "NHSVRDemo_RequestSubmitter" });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 35,
                column: "FriendlyName",
                value: "Roles");

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivity",
                columns: new[] { "ID", "FriendlyName", "Name" },
                values: new object[,]
                {
                    { 36, "Steward", "NHSSteward" },
                    { 37, "Transport", "NHSTransport" },
                    { 38, "NHS check in and chat", "NHSCheckInAndChat" },
                    { 39, "NHS check in and chat plus", "NHSCheckInAndChatPlus" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 35,
                column: "FriendlyName",
                value: "Advertising Roles");
        }
    }
}
