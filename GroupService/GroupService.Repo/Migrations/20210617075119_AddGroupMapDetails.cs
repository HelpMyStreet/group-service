using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddGroupMapDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FriendlyName",
                schema: "Group",
                table: "Group",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkURL",
                schema: "Group",
                table: "Group",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GroupMapDetails",
                schema: "Group",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false),
                    MapLocationID = table.Column<byte>(nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9, 6)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9, 6)", nullable: false),
                    ZoomLevel = table.Column<decimal>(type: "decimal(9, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GROUP_GROUP_MAP_DETAILS", x => new { x.GroupID, x.MapLocationID });
                    table.ForeignKey(
                        name: "FK_GroupCredential_GroupMapDetails",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupMapDetails",
                schema: "Group");

            migrationBuilder.DropColumn(
                name: "FriendlyName",
                schema: "Group",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "LinkURL",
                schema: "Group",
                table: "Group");
        }
    }
}
