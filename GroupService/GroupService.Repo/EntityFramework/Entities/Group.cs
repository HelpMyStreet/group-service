using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class Group
    {
        public Group()
        {
            Audit = new HashSet<Audit>();
            InverseParentGroup = new HashSet<Group>();
            Role = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public int? ParentGroupId { get; set; }

        public virtual Group ParentGroup { get; set; }
        public virtual ICollection<Audit> Audit { get; set; }
        public virtual ICollection<Group> InverseParentGroup { get; set; }
        public virtual ICollection<Role> Role { get; set; }
    }
}
