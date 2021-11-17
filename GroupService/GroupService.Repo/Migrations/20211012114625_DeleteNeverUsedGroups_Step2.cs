using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class DeleteNeverUsedGroups_Step2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -15);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "FriendlyName", "GeographicName", "GroupKey", "GroupName", "GroupType", "HomepageEnabled", "JoinGroupPopUpDetail", "LinkURL", "ParentGroupId", "ShiftsEnabled", "ShortName", "TasksEnabled" },
                values: new object[,]
                {
                    { -15, null, null, "pcn-grantham", "PCN Grantham", (byte)0, false, null, null, null, true, null, false },
                    { -16, null, null, "pcn-southlincoln", "PCN South Lincoln", (byte)0, false, null, null, null, true, null, false },
                    { -18, null, null, "pcn-spilsby", "PCN Spilsby", (byte)0, false, null, null, null, true, null, false },
                    { -19, null, null, "pcn-boston", "PCN Boston", (byte)0, false, null, null, null, true, null, false },
                    { -21, null, null, "pcn-lincoln-portland", "PCN Lincoln Portland", (byte)0, false, null, null, null, true, null, false },
                    { -26, null, null, "mansfield-wickes", "Mansfield (Wickes Site)", (byte)0, false, null, null, -25, true, null, false },
                    { -27, null, null, "gamston-community-hall", "Gamston Community Hall", (byte)0, false, null, null, -25, true, null, false },
                    { -28, null, null, "richard-herrod-centre", "Richard Herrod Centre", (byte)0, false, null, null, -25, true, null, false },
                    { -29, null, null, "kings-meadow-campus", "King's Meadow Campus", (byte)0, false, null, null, -25, true, null, false },
                    { -30, null, null, "forest-recreation-ground", "Forest Recreation Ground", (byte)0, false, null, null, -25, true, null, false }
                });
        }
    }
}
