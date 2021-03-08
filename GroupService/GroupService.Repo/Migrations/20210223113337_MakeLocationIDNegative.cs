using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class MakeLocationIDNegative : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -21, 10 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -20, 9 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -19, 8 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -18, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -17, 6 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -16, 5 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -15, 4 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -14, 3 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupLocation",
                columns: new[] { "GroupID", "LocationID" },
                values: new object[,]
                {
                    { -21, -10 },
                    { -19, -8 },
                    { -18, -7 },
                    { -17, -6 },
                    { -16, -5 },
                    { -15, -4 },
                    { -14, -3 },
                    { -20, -9 }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Location",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { -1, "LincolnCountyHospital" },
                    { -2, "PilgramHospitalBolton" },
                    { -4, "TableTennisClubGrantham" },
                    { -5, "WaddingtonBranchSurgerySouthLincoln" },
                    { -6, "StMarysMedicalPracticeStamford" },
                    { -7, "FranklinHallSpilsby" },
                    { -8, "SidingsMedicalPracticeBoston" },
                    { -9, "RustonsSportsAndSocialClubLincoln" },
                    { -3, "LouthCommunityHospital" },
                    { -10, "PortlandMedicalPracticeLincoln" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -21, -10 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -20, -9 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -19, -8 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -18, -7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -17, -6 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -16, -5 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -15, -4 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -14, -3 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -10);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -9);

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
                keyValue: -6);

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
                keyValue: -3);

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

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupLocation",
                columns: new[] { "GroupID", "LocationID" },
                values: new object[,]
                {
                    { -21, 10 },
                    { -19, 8 },
                    { -18, 7 },
                    { -17, 6 },
                    { -16, 5 },
                    { -15, 4 },
                    { -14, 3 },
                    { -20, 9 }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Location",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 10, "PortlandMedicalPracticeLincoln" },
                    { 9, "RustonsSportsAndSocialClubLincoln" },
                    { 7, "FranklinHallSpilsby" },
                    { 6, "StMarysMedicalPracticeStamford" },
                    { 5, "WaddingtonBranchSurgerySouthLincoln" },
                    { 4, "TableTennisClubGrantham" },
                    { 3, "LouthCommunityHospital" },
                    { 2, "PilgramHospitalBolton" },
                    { 8, "SidingsMedicalPracticeBoston" },
                    { 1, "LincolnCountyHospital" }
                });
        }
    }
}
