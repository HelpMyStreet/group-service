using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddDataForTasksEnabledFlag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                column: "HomepageEnabled",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -1,
                column: "TasksEnabled",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                column: "HomepageEnabled",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "HomepageEnabled", "TasksEnabled" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -1,
                column: "TasksEnabled",
                value: false);
        }
    }
}
