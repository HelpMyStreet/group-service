using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class DeleteMeadowsCommunityHelpers_Step3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -24, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -24, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -24, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -24, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -24, "a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupMapDetails",
                columns: new[] { "GroupID", "MapLocationID", "Latitude", "Longitude", "ZoomLevel" },
                values: new object[,]
                {
                    { -24, (byte)1, 52.94107706186348m, -1.1435562260432748m, 9m },
                    { -24, (byte)0, 52.94107706186348m, -1.1435562260432748m, 14m }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant", "TargetGroups" },
                values: new object[] { -24, "", (byte)13, (byte)5 });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "SuppressRecipientPersonalDetails", "TargetGroups" },
                values: new object[,]
                {
                    { -24, "", false, (byte)22, false, true, false, (byte)4 },
                    { -24, "a", true, (byte)23, false, false, false, (byte)4 }
                });
        }
    }
}
