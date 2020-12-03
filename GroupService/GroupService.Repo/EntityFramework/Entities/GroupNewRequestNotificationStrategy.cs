namespace GroupService.Repo.EntityFramework.Entities
{
    public class GroupNewRequestNotificationStrategy
    {
        public int GroupId { get; set; }
        public byte NewRequestNotificationStrategyId { get; set; }
        public int MaxVolunteer { get; set; }
        public virtual Group Group { get; set; }
    }
}
