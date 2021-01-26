using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddEnumLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.ID);
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Location",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "LincolnCountyHospital" },
                    { 2, "PilgramHospitalBolton" },
                    { 3, "LouthCommunityHospital" },
                    { 4, "TableTennisClubGrantham" },
                    { 5, "WaddingtonBranchSurgerySouthLincoln" },
                    { 6, "StMarysMedicalPracticeStamford" },
                    { 7, "FranklinHallSpilsby" },
                    { 8, "SidingsMedicalPracticeBoston" },
                    { 9, "RustonsSportsAndSocialClubLincoln" },
                    { 10, "PortlandMedicalPracticeLincoln" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location",
                schema: "Lookup");
        }
    }
}
