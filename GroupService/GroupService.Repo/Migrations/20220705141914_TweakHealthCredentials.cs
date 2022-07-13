using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakHealthCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 12,
                column: "Name",
                value: "Health and Safety Training");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -38, 12 },
                columns: new[] { "HowToAchieve", "Name" },
                values: new object[] { "The **Health, Safety and Infection Prevention and Control** for Volunteers training is a free, online learning module provided by Health Education England (HEE). <a href=\"https://portal.e-lfh.org.uk/Component/Details/556093\" target=\"_blank\">Launch the training module</a> and upload your completion certificate to continue. (You will need to log-in or sign up for a free account to access this training.)", "Health and Safety Training" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 12,
                column: "Name",
                value: "Health, Safety and Infection Prevention and Control for Volunteers");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -38, 12 },
                columns: new[] { "HowToAchieve", "Name" },
                values: new object[] { "This is a free, online learning module provided by Health Education England (HEE) on the e-learning for healthcare platform. Launch the training module and upload your completion certificate  to continue. (You will need to log-in or sign up for a free account to access this training.)", "Health, Safety and Infection Prevention and Control" });
        }
    }
}
