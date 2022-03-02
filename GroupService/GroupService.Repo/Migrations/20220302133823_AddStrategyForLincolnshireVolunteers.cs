﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddStrategyForLincolnshireVolunteers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                columns: new[] { "GroupID", "MaxVolunteer", "NewRequestNotificationStrategyId" },
                values: new object[] { -12, 2147483647, (byte)1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -12);
        }
    }
}