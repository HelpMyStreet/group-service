using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddGroupEmailConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupEmailConfiguration",
                schema: "Group",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupEmailVariantID = table.Column<byte>(nullable: false),
                    Configuration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupEmailConfiguration", x => new { x.GroupID, x.GroupEmailVariantID });
                    table.ForeignKey(
                        name: "FK_GroupEmailConfiguration_GroupID",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupEmailVariant",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupEmailVariant", x => x.ID);
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "GroupEmailVariantID", "Configuration" },
                values: new object[,]
                {
                    { -9, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -22, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -20, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -17, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -13, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -12, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -11, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -10, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at northmuskham@helpmystreet.org<p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>\"}]" },
                    { -23, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -24, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -7, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -6, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -5, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at tankersley@helpmystreet.org</p><p>P.S.Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about.Complete our Request Help form and let us know what they need.</p>\"}]" },
                    { -4, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"1\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -3, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -2, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"1\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -1, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"<p>If you haven’t done it already, you may like to complete your online ID verification now. We’ve made it as quick and easy as possible with the help of our partner, Yoti. Click here to launch your profile and get verified.</p><p>Most requests on our platform require ID verification to give people in need of help the confidence you are who you say you are. Some of our partner organisations may also require additional checks, if this is the case we’ll let you know when you click to accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.\"}]" },
                    { -8, (byte)1, "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at baldertoncs@helpmystreet.org</p><p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>\"}]" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "GroupEmailVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Welcome" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupEmailConfiguration",
                schema: "Group");

            migrationBuilder.DropTable(
                name: "GroupEmailVariant",
                schema: "Lookup");
        }
    }
}
