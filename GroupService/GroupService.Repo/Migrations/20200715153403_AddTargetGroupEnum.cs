using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddTargetGroupEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TargetGroup",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetGroup", x => x.ID);
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "TargetGroup",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 0, "ThisGroup" },
                    { 1, "ThisGroupAndChildren" },
                    { 2, "ParentGroup" },
                    { 3, "SiblingsAndParentGroup" },
                    { 4, "GenericGroup" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TargetGroup",
                schema: "Lookup");
        }
    }
}
