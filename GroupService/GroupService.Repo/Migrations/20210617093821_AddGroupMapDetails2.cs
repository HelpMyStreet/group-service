using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddGroupMapDetails2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Apex PCN Bank Staff", "/apexpcnbankstaff" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Southwell Torpedos", "/southwell" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Meadows Community Helpers", "/meadows-community-helpers" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Age Connects Cardiff & the Vale", "/ageconnects-cardiff" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Age UK Faversham & Sittingbourne", "/favershamandsittingbourne" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Lincolnshire Volunteers", "/lincolnshirevolunteers" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Age UK South Kent Coast", "/southkentcoast" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "North Muskham Community Support", "/north-muskham" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Age UK North West Kent", "/northwestkent" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Balderton Community Support", "/balderton" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Age UK Wirral", "/ageukwirral" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Ruddington Community Response Team", "/ruddington" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Tankersley & Pilley Community Helpers", "/tankersley" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Healthy London Partnership", "/healthylondonpartnership" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { "Age UK Lincoln & South Lincolnshire", "/ageuklsl" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -2,
                column: "FriendlyName",
                value: "For the Love of Scrubs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "FriendlyName", "LinkURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -2,
                column: "FriendlyName",
                value: null);
        }
    }
}
