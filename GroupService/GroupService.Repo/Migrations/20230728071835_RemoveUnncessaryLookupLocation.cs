using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveUnncessaryLookupLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -15);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -14);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -13);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -12);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -11);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -10);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -8);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -7);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Location",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { -15, "ForestRecreationGround" },
                    { -1, "LincolnCountyHospital" },
                    { -2, "PilgramHospitalBolton" },
                    { -4, "TableTennisClubGrantham" },
                    { -7, "FranklinHallSpilsby" },
                    { -8, "SidingsMedicalPracticeBoston" },
                    { -5, "WaddingtonBranchSurgerySouthLincoln" },
                    { -11, "MansfieldWickesSite" },
                    { -12, "GamstonCommunityHall" },
                    { -13, "RichardHerrodCentre" },
                    { -14, "KingsMeadowCampus" },
                    { -10, "PortlandMedicalPracticeLincoln" }
                });
        }
    }
}
