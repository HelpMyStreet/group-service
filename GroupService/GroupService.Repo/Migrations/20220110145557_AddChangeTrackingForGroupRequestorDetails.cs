using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddChangeTrackingForGroupRequestorDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[table_store_ChangeTracking_version]([TableName],[SYS_CHANGE_VERSION]) SELECT 'Group.RequestorDetails',0;
                ");

            migrationBuilder.Sql(@"
                ALTER TABLE [Group].[RequestorDetails] ENABLE CHANGE_TRACKING WITH (TRACK_COLUMNS_UPDATED = ON)
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM [dbo].[table_store_ChangeTracking_version] WHERE TableName='Group.RequestorDetailse';                
                ");

            migrationBuilder.Sql(@"
                ALTER TABLE [Group].[RequestorDetails] DISABLE CHANGE_TRACKING
                ");
        }
    }
}
