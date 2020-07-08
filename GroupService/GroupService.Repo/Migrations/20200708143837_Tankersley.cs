using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class Tankersley : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "TargetGroups",
                schema: "Website",
                table: "RequestHelpJourney",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "GroupKey", "GroupName", "ParentGroupId" },
                values: new object[] { -5, "tankersley", "Tankersley & Pilley", null });

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -3, "" },
                column: "TargetGroups",
                value: (byte)4);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -2, "" },
                column: "TargetGroups",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -1, "" },
                column: "TargetGroups",
                value: (byte)4);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -1, "DIY" },
                column: "TargetGroups",
                value: (byte)4);

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant" },
                values: new object[] { -5, "", (byte)0 });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "RequestHelpFormVariant", "TargetGroups" },
                values: new object[] { -5, "", (byte)1, (byte)4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -5, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -5, "" });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DropColumn(
                name: "TargetGroups",
                schema: "Website",
                table: "RequestHelpJourney");
        }
    }
}
