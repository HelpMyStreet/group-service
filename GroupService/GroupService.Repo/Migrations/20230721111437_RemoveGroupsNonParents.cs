using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveGroupsNonParents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "FriendlyName", "GeographicName", "GroupKey", "GroupName", "GroupType", "HomepageEnabled", "JoinGroupPopUpDetail", "LinkURL", "ParentGroupId", "ShiftsEnabled", "ShortName", "TasksEnabled" },
                values: new object[,]
                {
                    { -2, "For the Love of Scrubs", null, "ftlos", "For the Love of Scrubs", (byte)2, true, null, null, null, false, "FTLOS", true },
                    { -36, "VCS", null, "lincolnshire-vcs", "VCS", (byte)0, false, null, "/lincolnshire-vcs", -12, false, "VCS", true },
                    { -37, "LCVS", null, "lincolnshire-lcvs", "LCVS", (byte)0, false, null, "/lincolnshire-lcvs", -12, false, "LCVS", true },
                    { -34, "Boston and Surrounding Areas", "Boston or surrounding areas", "boston", "Boston and Surrounding Areas", (byte)0, true, null, "/boston", null, false, "Boston", true },
                    { -33, "Age UK Mid Mersey", "St Helens, Halton, Knowsley and Warrington", "ageuk-midmersey", "Age UK Mid Mersey", (byte)0, true, null, "/ageukmidmersey", null, false, "Age UK MM", true },
                    { -32, "Apex PCN Bank Staff", null, "apex-pcn-bank-staff", "APEX PCN Bank Staff", (byte)0, true, null, "/apexpcnbankstaff", null, true, "Apex Bank Staff", false },
                    { -23, "Age Connects Cardiff & the Vale", "Cardiff & the Vale", "ageconnects-cardiff", "Age Connects Cardiff & the Vale", (byte)1, true, @"Age Connects Cardiff & the Vale require two references, an Induction Session and (in most cases) a DBS check before you can start volunteering.

                You will also be expected to make a minimum commitment of six months.", "/ageconnects-cardiff", null, false, "Age Connects Cardiff", true },
                    { -20, null, null, "apex-pcn-lincoln", "APEX PCN", (byte)0, false, null, null, -12, true, null, false },
                    { -39, null, null, "nhsvr-group1", "Nottinghamshire County Council", (byte)0, false, null, null, -38, true, null, true },
                    { -17, null, null, "four-counties-pcn", "Four Counties PCN", (byte)0, false, null, null, -12, true, null, false },
                    { -13, "Age UK Faversham & Sittingbourne", "Faversham or Sittingbourne", "ageuk-favershamandsittingbourne", "Age UK Faversham & Sittingbourne", (byte)0, true, null, "/favershamandsittingbourne", null, false, "Faversham & Sittingbourne", true },
                    { -11, "Age UK South Kent Coast", "Deal or Folkestone", "ageuk-southkentcoast", "Age UK South Kent Coast", (byte)0, true, null, "/southkentcoast", null, false, "South Kent Coast", true },
                    { -10, "North Muskham Community Support", "North Muskham", "north-muskham", "North Muskham Community Support", (byte)0, true, null, "/north-muskham", null, false, "North Muskham", true },
                    { -9, "Age UK North West Kent", "North West Kent (Dartford, Swanley or Gravesend)", "ageuknwkent", "Age UK North West Kent", (byte)0, true, null, "/northwestkent", null, false, "Age UK NW Kent", true },
                    { -8, "Balderton Community Support", "Balderton", "balderton", "Balderton Community Support", (byte)0, true, null, "/balderton", null, false, "Balderton", true },
                    { -5, "Tankersley & Pilley Community Helpers", "Tankersley or Pilley", "tankersley", "Tankersley & Pilley", (byte)0, true, null, "/tankersley", null, false, "Tankersley", true },
                    { -3, "Age UK Lincoln & South Lincolnshire", null, "ageuklsl", "Age UK Lincoln & South Lincolnshire", (byte)1, true, null, "/ageuklsl", null, false, "Age UK LSL", true },
                    { -14, null, null, "east-lindsey-pcn", "East Lindsey PCN", (byte)0, false, null, null, -12, true, null, false },
                    { -40, null, null, "nhsvr-group2", "NHS Nottingham & Nottinghamshire Integrated Care Board", (byte)1, false, null, null, -38, true, null, true }
                });
        }
    }
}
