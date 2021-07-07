using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddGroupType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "GroupType",
                schema: "Group",
                table: "Group",
                nullable: false,
                defaultValue: (byte)0);            

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23,
                column: "GroupType",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -22,
                column: "GroupType",
                value: (byte)2);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -12,
                column: "GroupType",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -3,
                column: "GroupType",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -2,
                column: "GroupType",
                value: (byte)2);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -1,
                column: "GroupType",
                value: (byte)2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupType",
                schema: "Group",
                table: "Group");
        }
    }
}
