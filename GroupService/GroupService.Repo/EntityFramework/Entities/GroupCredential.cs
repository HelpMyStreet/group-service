using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class GroupCredential
    {
        public GroupCredential()
        {
            CredentialSet = new HashSet<CredentialSet>();
            UserCredential = new HashSet<UserCredential>();
        }
        public int GroupId { get; set; }
        public int CredentialId { get; set; }
        public byte CredentialTypeId { get; set; }
        public string Name { get; set; }
        public string HowToAchieve { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Credential Credential { get; set; }
        public virtual Group Group { get; set; }

        public virtual ICollection<CredentialSet> CredentialSet { get; set; }
        public virtual ICollection<UserCredential> UserCredential { get; set; }
    }
}
