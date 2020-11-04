using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class GroupSupportActivityInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupportActivityInstructions",
                schema: "Group",
                columns: table => new
                {
                    SupportActivityInstructionsID = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instructions = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportActivityInstructions", x => x.SupportActivityInstructionsID);
                });

            migrationBuilder.CreateTable(
                name: "SupportActivity",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportActivity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SupportActivityInstructions",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportActivityInstructions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GroupSupportActivityInstructions",
                schema: "Group",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupportActivityID = table.Column<int>(nullable: false),
                    SupportActivityInstructionsID = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupSupportActivityInstructions", x => new { x.GroupID, x.SupportActivityID });
                    table.ForeignKey(
                        name: "FK_GroupSupportActivityInstructions_GroupID",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupSupportActivityInstructions_SupportActivityInstructionsID",
                        column: x => x.SupportActivityInstructionsID,
                        principalSchema: "Group",
                        principalTable: "SupportActivityInstructions",
                        principalColumn: "SupportActivityInstructionsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivity",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Shopping" },
                    { 16, "Transport" },
                    { 15, "ColdWeatherArmy" },
                    { 13, "WellbeingPackage" },
                    { 12, "FaceMask" },
                    { 11, "Other" },
                    { 10, "CheckingIn" },
                    { 9, "HomeworkSupport" },
                    { 14, "CommunityConnector" },
                    { 7, "PhoneCalls_Friendly" },
                    { 6, "MealPreparation" },
                    { 5, "DogWalking" },
                    { 4, "MedicalAppointmentTransport" },
                    { 3, "Errands" },
                    { 2, "CollectingPrescriptions" },
                    { 8, "PhoneCalls_Anxious" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 10, "AgeUKWirral_Shopping" },
                    { 9, "AgeUKLincoln_V4V" },
                    { 8, "FTLOS_FaceCovering" },
                    { 7, "HMS_FaceCovering" },
                    { 6, "HMS_CheckIn" },
                    { 3, "HMS_General" },
                    { 4, "HMS_FriendlyChat" },
                    { 2, "HMS_OtherPurchase" },
                    { 1, "HMS_Shopping" },
                    { 11, "AgeUKWirral_Prescriptions" },
                    { 5, "HMS_Homework" },
                    { 12, "AgeUKWirral_General" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupSupportActivityInstructions_SupportActivityInstructionsID",
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                column: "SupportActivityInstructionsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupSupportActivityInstructions",
                schema: "Group");

            migrationBuilder.DropTable(
                name: "SupportActivity",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "SupportActivityInstructions",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "SupportActivityInstructions",
                schema: "Group");
        }
    }
}
