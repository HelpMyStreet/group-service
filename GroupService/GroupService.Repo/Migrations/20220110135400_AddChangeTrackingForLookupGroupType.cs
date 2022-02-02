using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddChangeTrackingForLookupGroupType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[table_store_ChangeTracking_version]([TableName],[SYS_CHANGE_VERSION]) SELECT 'Lookup.GroupType',0;
                ");

            migrationBuilder.Sql(@"
                ALTER TABLE [Lookup].[GroupType] ENABLE CHANGE_TRACKING WITH (TRACK_COLUMNS_UPDATED = ON)
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM [dbo].[table_store_ChangeTracking_version] WHERE TableName='Lookup.GroupType';                
                ");

            migrationBuilder.Sql(@"
                ALTER TABLE [Lookup].[GroupType] DISABLE CHANGE_TRACKING
                ");
        }
    }
}
