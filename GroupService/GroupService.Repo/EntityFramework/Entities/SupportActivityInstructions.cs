using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class SupportActivityInstructions
    {
        public SupportActivityInstructions()
        {
            GroupSupportActivityInstructions = new HashSet<GroupSupportActivityInstructions>();
        }

        public short SupportActivityInstructionsId { get; set; }
        public string Instructions { get; set; }

        public virtual ICollection<GroupSupportActivityInstructions> GroupSupportActivityInstructions { get; set; }
    }
}
