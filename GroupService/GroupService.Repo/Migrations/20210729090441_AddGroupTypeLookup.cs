using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddGroupTypeLookup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupType",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupType", x => x.ID);
                });
            
            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "GroupType",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 0, "Local" },
                    { 1, "Regional" },
                    { 2, "National" },
                    { 3, "HelpMyStreet" }
                });            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupType",
                schema: "Lookup");            
        }
    }
}
