using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakDbDesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CredentialSet_CredentialID",
                schema: "Group",
                table: "CredentialSet");

            migrationBuilder.DropForeignKey(
                name: "FK_CredentialSet_GroupID",
                schema: "Group",
                table: "CredentialSet");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCredential_CredentialID",
                schema: "Group",
                table: "UserCredential");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCredential_GroupID",
                schema: "Group",
                table: "UserCredential");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCredential",
                schema: "Group",
                table: "UserCredential");

            migrationBuilder.DropIndex(
                name: "IX_UserCredential_CredentialID",
                schema: "Group",
                table: "UserCredential");

            migrationBuilder.DropIndex(
                name: "IX_CredentialSet_CredentialID",
                schema: "Group",
                table: "CredentialSet");

            migrationBuilder.DropIndex(
                name: "IX_CredentialSet_GroupID",
                schema: "Group",
                table: "CredentialSet");

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -1, -1 });

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                schema: "Group",
                table: "UserCredential",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCredential",
                schema: "Group",
                table: "UserCredential",
                columns: new[] { "GroupID", "UserID", "CredentialID", "DateAdded" });

            migrationBuilder.CreateIndex(
                name: "IX_UserCredential_GroupID_CredentialID",
                schema: "Group",
                table: "UserCredential",
                columns: new[] { "GroupID", "CredentialID" });

            migrationBuilder.CreateIndex(
                name: "IX_CredentialSet_GroupID_CredentialID",
                schema: "Group",
                table: "CredentialSet",
                columns: new[] { "GroupID", "CredentialID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CredentialSet_CredentialID",
                schema: "Group",
                table: "CredentialSet",
                columns: new[] { "GroupID", "CredentialID" },
                principalSchema: "Group",
                principalTable: "GroupCredential",
                principalColumns: new[] { "GroupID", "CredentialID" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCredential_CredentialID",
                schema: "Group",
                table: "UserCredential",
                columns: new[] { "GroupID", "CredentialID" },
                principalSchema: "Group",
                principalTable: "GroupCredential",
                principalColumns: new[] { "GroupID", "CredentialID" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CredentialSet_CredentialID",
                schema: "Group",
                table: "CredentialSet");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCredential_CredentialID",
                schema: "Group",
                table: "UserCredential");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCredential",
                schema: "Group",
                table: "UserCredential");

            migrationBuilder.DropIndex(
                name: "IX_UserCredential_GroupID_CredentialID",
                schema: "Group",
                table: "UserCredential");

            migrationBuilder.DropIndex(
                name: "IX_CredentialSet_GroupID_CredentialID",
                schema: "Group",
                table: "CredentialSet");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                schema: "Group",
                table: "UserCredential",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCredential",
                schema: "Group",
                table: "UserCredential",
                columns: new[] { "GroupID", "UserID", "CredentialID" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "DisplayOrder", "HowToAchieve", "Name" },
                values: new object[] { -1, -1, (byte)1, 1, "Use Yoti App", "Yoti Identity Verification" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "DisplayOrder", "HowToAchieve", "Name" },
                values: new object[] { -2, -1, (byte)1, 1, "Use Yoti App", "Yoti Identity Verification" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "DisplayOrder", "HowToAchieve", "Name" },
                values: new object[] { -2, 1, (byte)1, 2, "Email someone", "Yoti Identity Verification" });

            migrationBuilder.CreateIndex(
                name: "IX_UserCredential_CredentialID",
                schema: "Group",
                table: "UserCredential",
                column: "CredentialID");

            migrationBuilder.CreateIndex(
                name: "IX_CredentialSet_CredentialID",
                schema: "Group",
                table: "CredentialSet",
                column: "CredentialID");

            migrationBuilder.CreateIndex(
                name: "IX_CredentialSet_GroupID",
                schema: "Group",
                table: "CredentialSet",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_CredentialSet_CredentialID",
                schema: "Group",
                table: "CredentialSet",
                column: "CredentialID",
                principalSchema: "Group",
                principalTable: "Credential",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CredentialSet_GroupID",
                schema: "Group",
                table: "CredentialSet",
                column: "GroupID",
                principalSchema: "Group",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCredential_CredentialID",
                schema: "Group",
                table: "UserCredential",
                column: "CredentialID",
                principalSchema: "Group",
                principalTable: "Credential",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCredential_GroupID",
                schema: "Group",
                table: "UserCredential",
                column: "GroupID",
                principalSchema: "Group",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
