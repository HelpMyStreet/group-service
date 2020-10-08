using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class populateCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                schema: "Group",
                table: "CredentialSet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ID",
                schema: "Group",
                table: "CredentialSet",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                schema: "Group",
                table: "Credential",
                columns: new[] { "ID", "Name" },
                values: new object[] { -1, "IdentityVerifiedByYoti" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "Credential",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "ManuallyVerified" });
        }
    }
}
