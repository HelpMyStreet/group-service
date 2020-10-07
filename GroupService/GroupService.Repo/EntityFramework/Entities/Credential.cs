using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class Credential
    {
        public Credential()
        {
            CredentialSet = new HashSet<CredentialSet>();
            GroupCredential = new HashSet<GroupCredential>();
            UserCredential = new HashSet<UserCredential>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CredentialSet> CredentialSet { get; set; }
        public virtual ICollection<GroupCredential> GroupCredential { get; set; }
        public virtual ICollection<UserCredential> UserCredential { get; set; }
    }
}
