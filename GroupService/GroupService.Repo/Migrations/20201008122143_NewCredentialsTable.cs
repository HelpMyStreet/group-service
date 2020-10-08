using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class NewCredentialsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityCredentialSet",
                schema: "Group",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false),
                    ActivityID = table.Column<int>(nullable: false),
                    CredentialSetID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityCredentialSet", x => new { x.GroupID, x.ActivityID, x.CredentialSetID });
                    table.ForeignKey(
                        name: "FK_ActivityCredentialSet_GroupID",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Credential",
                schema: "Group",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credential", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CredentialTypes",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GroupCredential",
                schema: "Group",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false),
                    CredentialID = table.Column<int>(nullable: false),
                    CredentialTypeID = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    HowToAchieve = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GROUP_CREDENTIAL", x => new { x.GroupID, x.CredentialID });
                    table.ForeignKey(
                        name: "FK_GroupCredential_CredentialID",
                        column: x => x.CredentialID,
                        principalSchema: "Group",
                        principalTable: "Credential",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupCredential_Group",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CredentialSet",
                schema: "Group",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    GroupID = table.Column<int>(nullable: false),
                    CredentialID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialSet", x => new { x.ID, x.GroupID, x.CredentialID });
                    table.ForeignKey(
                        name: "FK_CredentialSet_CredentialID",
                        columns: x => new { x.GroupID, x.CredentialID },
                        principalSchema: "Group",
                        principalTable: "GroupCredential",
                        principalColumns: new[] { "GroupID", "CredentialID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserCredential",
                schema: "Group",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    CredentialID = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ValidUntil = table.Column<DateTime>(type: "datetime", nullable: true),
                    AuthorisedByUserID = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Notes = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCredential", x => new { x.GroupID, x.UserID, x.CredentialID, x.DateAdded });
                    table.ForeignKey(
                        name: "FK_UserCredential_CredentialID",
                        columns: x => new { x.GroupID, x.CredentialID },
                        principalSchema: "Group",
                        principalTable: "GroupCredential",
                        principalColumns: new[] { "GroupID", "CredentialID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CredentialTypes",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "IdentityVerification" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CredentialTypes",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "ThirdPartyCheck" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CredentialTypes",
                columns: new[] { "ID", "Name" },
                values: new object[] { 3, "Training" });

            migrationBuilder.CreateIndex(
                name: "IX_CredentialSet_GroupID_CredentialID",
                schema: "Group",
                table: "CredentialSet",
                columns: new[] { "GroupID", "CredentialID" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupCredential_CredentialID",
                schema: "Group",
                table: "GroupCredential",
                column: "CredentialID");

            migrationBuilder.CreateIndex(
                name: "IX_UserCredential_GroupID_CredentialID",
                schema: "Group",
                table: "UserCredential",
                columns: new[] { "GroupID", "CredentialID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityCredentialSet",
                schema: "Group");

            migrationBuilder.DropTable(
                name: "CredentialSet",
                schema: "Group");

            migrationBuilder.DropTable(
                name: "UserCredential",
                schema: "Group");

            migrationBuilder.DropTable(
                name: "CredentialTypes",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "GroupCredential",
                schema: "Group");

            migrationBuilder.DropTable(
                name: "Credential",
                schema: "Group");
        }
    }
}
