using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class SetTargetGroupsForRegistrationFormVariant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "TargetGroups",
                schema: "Website",
                table: "RegistrationJourney",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "TargetGroup",
                columns: new[] { "ID", "Name" },
                values: new object[] { 5, "ThisGroupAndGenericGroup" });

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -31, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -25, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -24, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -23, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -13, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -12, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -11, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -10, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -9, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -8, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -7, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -6, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -5, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -4, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -3, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -2, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -1, "" },
                column: "TargetGroups",
                value: (byte)5);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -1, "face-masks" },
                column: "TargetGroups",
                value: (byte)5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "TargetGroup",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "TargetGroups",
                schema: "Website",
                table: "RegistrationJourney");
        }
    }
}
