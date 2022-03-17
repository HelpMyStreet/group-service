using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveArroweParkHospital_Step1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 11, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 11, 351 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 34, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 34, 351 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 35, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 35, 351 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 36, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 36, 351 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 37, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -35, 37, 351 });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 31, "ArroweParkHospital_RequestSubmitter" });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 35,
                column: "FriendlyName",
                value: "Lunch Visit");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 36,
                column: "FriendlyName",
                value: "Medication Check In");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.InsertData(
                schema: "Group",
                table: "ActivityCredentialSet",
                columns: new[] { "GroupID", "ActivityID", "CredentialSetID", "DisplayOrder" },
                values: new object[,]
                {
                    { -35, 34, 35, 0 },
                    { -35, 35, 35, 0 },
                    { -35, 36, 35, 0 },
                    { -35, 37, 35, 0 },
                    { -35, 11, 35, 0 },
                    { -35, 34, 351, 0 },
                    { -35, 35, 351, 0 },
                    { -35, 36, 351, 0 },
                    { -35, 37, 351, 0 },
                    { -35, 11, 351, 0 }
                });

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 35,
                column: "FriendlyName",
                value: "Lunch visit");

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 36,
                column: "FriendlyName",
                value: "Medication Checkin");
        }
    }
}
