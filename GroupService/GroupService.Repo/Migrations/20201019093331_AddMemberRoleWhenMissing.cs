using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddMemberRoleWhenMissing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SELECT UserID,GroupID,1 as RoleId
                INTO #AddMissing
                FROM [Group].[UserRole]
                GROUP BY UserID,GroupID
                HAVING sum(case when RoleID=1 then 1 when RoleID=6 then 1 else 0 end) = 0
                
                INSERT INTO [Group].[UserRole] ([UserID],[GroupID],[RoleID])
                SELECT [UserID],[GroupID],[RoleID]
                FROM #AddMissing

                INSERT INTO [Group].[UserRoleAudit] ([AuthorisedByUserID],[UserID],[GroupID],[RoleID],[DateRequested],[ActionID],[Success])
                SELECT -1, [UserID],[GroupID],[RoleID],GETDATE(),1,1
                FROM #AddMissing

                DROP TABLE #AddMissing
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
