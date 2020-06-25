using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit",
                schema: "Audit");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                schema: "User",
                table: "UserRole");

            migrationBuilder.RenameTable(
                name: "UserRole",
                schema: "User",
                newName: "UserRole",
                newSchema: "Group");

            migrationBuilder.AddColumn<int>(
                name: "GroupID",
                schema: "Group",
                table: "UserRole",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                schema: "Group",
                table: "UserRole",
                columns: new[] { "GroupID", "UserID", "RoleID" });

            migrationBuilder.CreateTable(
                name: "UserRoleAudit",
                schema: "Audit",
                columns: table => new
                {
                    AuthorisedByUserID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    GroupID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime", nullable: false),
                    ActionID = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleAudit", x => new { x.AuthorisedByUserID, x.UserID, x.GroupID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_Audit_Group",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleAudit_GroupID",
                schema: "Audit",
                table: "UserRoleAudit",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Group",
                schema: "Group",
                table: "UserRole",
                column: "GroupID",
                principalSchema: "Group",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_Group",
                schema: "Group",
                table: "UserRole");

            migrationBuilder.DropTable(
                name: "UserRoleAudit",
                schema: "Audit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                schema: "Group",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "GroupID",
                schema: "Group",
                table: "UserRole");

            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.RenameTable(
                name: "UserRole",
                schema: "Group",
                newName: "UserRole",
                newSchema: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                schema: "User",
                table: "UserRole",
                columns: new[] { "UserID", "RoleID" });

            migrationBuilder.CreateTable(
                name: "Audit",
                schema: "Audit",
                columns: table => new
                {
                    AuthorisedByUserID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    GroupID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    ActionID = table.Column<byte>(nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit", x => new { x.AuthorisedByUserID, x.UserID, x.GroupID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_Audit_Group",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Group",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => new { x.GroupID, x.UserID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_Role_Group",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audit_GroupID",
                schema: "Audit",
                table: "Audit",
                column: "GroupID");
        }
    }
}
