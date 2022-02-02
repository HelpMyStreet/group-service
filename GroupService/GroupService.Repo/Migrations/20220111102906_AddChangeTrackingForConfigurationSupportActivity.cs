using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddChangeTrackingForConfigurationSupportActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[table_store_ChangeTracking_version]([TableName],[SYS_CHANGE_VERSION]) SELECT 'Configuration.SupportActivity',0;
                ");

            migrationBuilder.Sql(@"
                ALTER TABLE [Configuration].[SupportActivity] ENABLE CHANGE_TRACKING WITH (TRACK_COLUMNS_UPDATED = ON)
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM [dbo].[table_store_ChangeTracking_version] WHERE TableName='Configuration.SupportActivity';                
                ");

            migrationBuilder.Sql(@"
                ALTER TABLE [Configuration].[SupportActivity] DISABLE CHANGE_TRACKING
                ");
        }
    }
}
