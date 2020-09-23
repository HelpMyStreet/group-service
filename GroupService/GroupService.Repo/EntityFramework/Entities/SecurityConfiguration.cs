namespace GroupService.Repo.EntityFramework.Entities
{
    public class SecurityConfiguration
    {
        public int GroupId { get; set; }
        public bool AllowAutonomousJoinersAndLeavers { get; set; }

        public virtual Group Group { get; set; }
    }
}
