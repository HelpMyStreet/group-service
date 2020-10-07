using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class GroupCredential
    {
        public int GroupId { get; set; }
        public int CredentialId { get; set; }
        public byte CredentialTypeId { get; set; }
        public string Name { get; set; }
        public string HowToAchieve { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Credential Credential { get; set; }
        public virtual Group Group { get; set; }
    }
}
