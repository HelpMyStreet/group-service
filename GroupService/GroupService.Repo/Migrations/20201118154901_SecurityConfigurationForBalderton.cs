﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class SecurityConfigurationForBalderton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "SecurityConfiguration",
                columns: new[] { "GroupID", "AllowAutonomousJoinersAndLeavers" },
                values: new object[] { -8, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SecurityConfiguration",
                keyColumn: "GroupID",
                keyValue: -8);
        }
    }
}
