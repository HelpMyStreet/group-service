using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddGroupKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GroupKey",
                schema: "Group",
                table: "Group",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -1,
                column: "GroupKey",
                value: "Generic");

            migrationBuilder.CreateIndex(
                name: "UC_GroupKey",
                schema: "Group",
                table: "Group",
                column: "GroupKey",
                unique: true,
                filter: "[GroupKey] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UC_GroupKey",
                schema: "Group",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "GroupKey",
                schema: "Group",
                table: "Group");
        }
    }
}
