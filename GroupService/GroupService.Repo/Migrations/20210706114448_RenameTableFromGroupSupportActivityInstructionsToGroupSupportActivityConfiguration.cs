﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RenameTableFromGroupSupportActivityInstructionsToGroupSupportActivityConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER TABLE [Group].[GroupSupportActivityInstructions]  
                DISABLE CHANGE_TRACKING;
                ");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupSupportActivityInstructions",
                schema: "Group",
                table: "GroupSupportActivityInstructions");

            migrationBuilder.RenameTable(
                name: "GroupSupportActivityInstructions",
                schema: "Group",
                newName: "GroupSupportActivityConfiguration",
                newSchema: "Group");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSupportActivityInstructions_SupportActivityInstructionsID",
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                newName: "IX_GroupSupportActivityConfiguration_SupportActivityInstructionsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupSupportActivityConfiguration",
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID" });

            migrationBuilder.Sql(@"
                ALTER TABLE [Group].[GroupSupportActivityConfiguration]
                ENABLE CHANGE_TRACKING  
                WITH (TRACK_COLUMNS_UPDATED = ON)
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER TABLE [Group].[GroupSupportActivityConfiguration]  
                DISABLE CHANGE_TRACKING;
                ");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupSupportActivityConfiguration",
                schema: "Group",
                table: "GroupSupportActivityConfiguration");

            migrationBuilder.RenameTable(
                name: "GroupSupportActivityConfiguration",
                schema: "Group",
                newName: "GroupSupportActivityInstructions",
                newSchema: "Group");

            migrationBuilder.RenameIndex(
                name: "IX_GroupSupportActivityConfiguration_SupportActivityInstructionsID",
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                newName: "IX_GroupSupportActivityInstructions_SupportActivityInstructionsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupSupportActivityInstructions",
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID" });

            migrationBuilder.Sql(@"
                ALTER TABLE [Group].[GroupSupportActivityInstructions]
                ENABLE CHANGE_TRACKING  
                WITH (TRACK_COLUMNS_UPDATED = ON)
                ");
        }
    }
}
