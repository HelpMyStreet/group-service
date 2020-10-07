using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class CredentialSet
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int CredentialId { get; set; }

        public virtual Credential Credential { get; set; }
        public virtual Group Group { get; set; }
    }
}
