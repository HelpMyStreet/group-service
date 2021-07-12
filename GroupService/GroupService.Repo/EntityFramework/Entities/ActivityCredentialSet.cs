using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class ActivityCredentialSet
    {
        public int GroupId { get; set; }
        public int ActivityId { get; set; }
        public int CredentialSetId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Group Group { get; set; }
    }
}
