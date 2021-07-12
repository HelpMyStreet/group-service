using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class SupportActivityInstructions
    {
        public SupportActivityInstructions()
        {
            GroupSupportActivityInstructions = new HashSet<GroupSupportActivityConfiguration>();
        }

        public short SupportActivityInstructionsId { get; set; }
        public string Instructions { get; set; }

        public virtual ICollection<GroupSupportActivityConfiguration> GroupSupportActivityInstructions { get; set; }
    }
}
