using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class Group
    {
        public Group()
        {
            ActivityCredentialSet = new HashSet<ActivityCredentialSet>();            
            GroupCredential = new HashSet<GroupCredential>();
            InverseParentGroup = new HashSet<Group>();
            UserRole = new HashSet<UserRole>();
            RegistrationJourney = new HashSet<RegistrationJourney>();
            RequestHelpJourney = new HashSet<RequestHelpJourney>();
            GroupSupportActivityInstructions = new HashSet<GroupSupportActivityInstructions>();
            GroupLocation = new HashSet<GroupLocation>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupKey { get; set; }
        public int? ParentGroupId { get; set; }
        public bool ShiftsEnabled { get; set; }
        public bool TasksEnabled { get; set; }
        public bool HomepageEnabled { get; set; }

        public virtual Group ParentGroup { get; set; }
        public virtual RequestorDetails RequestorDetails { get; set; }        
        public virtual ICollection<Group> InverseParentGroup { get; set; }
        public virtual ICollection<RegistrationJourney> RegistrationJourney { get; set; }
        public virtual ICollection<RequestHelpJourney> RequestHelpJourney { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual SecurityConfiguration SecurityConfiguration { get; set; }
        public virtual GroupNewRequestNotificationStrategy NewRequestNotificationStrategy { get; set; }
        public virtual ICollection<ActivityCredentialSet> ActivityCredentialSet { get; set; }        
        public virtual ICollection<GroupCredential> GroupCredential { get; set; }
        public virtual ICollection<GroupLocation> GroupLocation { get; set; }
        public virtual ICollection<GroupSupportActivityInstructions> GroupSupportActivityInstructions { get; set; }
        public virtual ICollection<GroupEmailConfiguration> GroupEmailConfiguration { get; set; }
    }
}
