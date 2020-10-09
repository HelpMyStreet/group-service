using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class Credential
    {
        public Credential()
        {
            GroupCredential = new HashSet<GroupCredential>();            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<GroupCredential> GroupCredential { get; set; }        
    }
}
