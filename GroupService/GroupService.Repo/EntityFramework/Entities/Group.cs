using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class Group
    {
        public Group()
        {
            InverseParentGroup = new HashSet<Group>();
            UserRole = new HashSet<UserRole>();
            RegistrationJourney = new HashSet<RegistrationJourney>();
            RequestHelpJourney = new HashSet<RequestHelpJourney>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupKey { get; set; }
        public int? ParentGroupId { get; set; }

        public virtual Group ParentGroup { get; set; }
        public virtual ICollection<Group> InverseParentGroup { get; set; }
        public virtual ICollection<RegistrationJourney> RegistrationJourney { get; set; }
        public virtual ICollection<RequestHelpJourney> RequestHelpJourney { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
