using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class SetNationalActivityRadius : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 12 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -22, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -13, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -10, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -9, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -8, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 12 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 9 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 12 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -2, 12 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 7 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 9 },
                column: "Radius",
                value: 2000.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 12 },
                column: "Radius",
                value: 2000.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 12 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -22, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -13, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -11, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -10, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -9, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -8, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -6, 12 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 9 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -5, 12 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -2, 12 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 7 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 9 },
                column: "Radius",
                value: 20.0);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -1, 12 },
                column: "Radius",
                value: 20.0);
        }
    }
}
