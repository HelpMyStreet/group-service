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
            CredentialSet = new HashSet<CredentialSet>();
            GroupCredential = new HashSet<GroupCredential>();
            InverseParentGroup = new HashSet<Group>();
            UserRole = new HashSet<UserRole>();
            RegistrationJourney = new HashSet<RegistrationJourney>();
            RequestHelpJourney = new HashSet<RequestHelpJourney>();
            UserCredential = new HashSet<UserCredential>();
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
        public virtual SecurityConfiguration SecurityConfiguration { get; set; }

        public virtual ICollection<ActivityCredentialSet> ActivityCredentialSet { get; set; }
        public virtual ICollection<CredentialSet> CredentialSet { get; set; }
        public virtual ICollection<GroupCredential> GroupCredential { get; set; }
        public virtual ICollection<UserCredential> UserCredential { get; set; }
    }
}
