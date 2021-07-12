using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddGroupSupportRadius : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Radius",
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "RequestEvent",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestEvent", x => x.ID);
                });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -32, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -32, 32 },
                column: "Radius",
                value: 200.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -31, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -31, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -31, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -30, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -29, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -28, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -27, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -26, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -25, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 3 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 10 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 12 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 22 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 29 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 30 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 31 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 16 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 22 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 26 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 27 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 28 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -22, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -22, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -22, 3 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -22, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -22, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -22, 22 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -22, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -22, 25 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -21, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -20, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -19, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -18, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -17, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -16, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -15, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -14, 24 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -13, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -13, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -13, 16 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -13, 21 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -13, 22 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -12, 22 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -12, 25 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 21 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 22 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 23 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -10, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -10, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -10, 3 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -10, 5 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -10, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -10, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -9, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -9, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -9, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -9, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -9, 21 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -9, 22 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -8, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -8, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -8, 5 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -8, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -8, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -7, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -7, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -7, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -7, 15 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -7, 22 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 3 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 5 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 6 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 10 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 12 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 22 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 3 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 6 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 9 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 10 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 12 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -3, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -3, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -3, 3 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -3, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -3, 13 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -3, 22 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -2, 12 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 1 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 2 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 3 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 6 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 9 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 10 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 11 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 12 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RequestEvent",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "ShowFullPostCode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestEvent",
                schema: "Lookup");

            migrationBuilder.DropColumn(
                name: "Radius",
                schema: "Group",
                table: "GroupSupportActivityInstructions");
        }
    }
}
