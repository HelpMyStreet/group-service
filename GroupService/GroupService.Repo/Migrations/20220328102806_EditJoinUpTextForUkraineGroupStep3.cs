using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class EditJoinUpTextForUkraineGroupStep3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -35,
                column: "JoinGroupPopUpDetail",
                value: @"This group has been created to help prospective UK hosts find a suitable match for the UK Government Homes for Ukraine Scheme. Please only register if the following apply: 
* You are 18 or over
* You are able to offer accommodation for at least 6 months
* You are a British citizen or have leave to remain in the UK for at least 6 months
* You are looking to be a sponsor for UK Government Homes for Ukraine Scheme
* You will submit a separate application to the UK Government Homes for Ukraine Scheme once a match has been confirmed
You will need to verify your identity with photographic ID to access a match using this site. The UK Government may also carry out their own checks following an application to the scheme. Please only continue with your registration if you can meet these terms.");

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CommunicationJobType",
                columns: new[] { "ID", "Name" },
                values: new object[] { 19, "TaskAppliedForNotification" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "CommunicationJobType",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -35,
                column: "JoinGroupPopUpDetail",
                value: "This group has been created to help prospective UK hosts find a suitable match for the UK Government Homes for Ukraine Scheme. Please only register if the following apply: * You are 18 or over* You are able to offer accommodation for at least 6 months* You are a British citizen or have leave to remain in the UK for at least 6 months* You are looking to be a sponsor for UK Government Homes for Ukraine Scheme<* You will submit a separate application to the UK Government Homes for Ukraine Scheme once a match has been confirmedYou will need to verify your identity with photographic ID to access a match using this site. The UK Government may also carry out their own checks following an application to the scheme. Please only continue with your registration if you can meet these terms.");
        }
    }
}
