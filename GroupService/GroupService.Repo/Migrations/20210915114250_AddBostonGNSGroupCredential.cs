﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddBostonGNSGroupCredential : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Credential",
                columns: new[] { "ID", "Name" },
                values: new object[] { 10, "Safeguarding Training" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 10);
        }
    }
}
