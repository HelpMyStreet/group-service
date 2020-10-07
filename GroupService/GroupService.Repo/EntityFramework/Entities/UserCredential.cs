using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class UserCredential
    {
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int CredentialId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? ValidUntil { get; set; }
        public int AuthorisedByUserId { get; set; }
        public string Reference { get; set; }
        public string Notes { get; set; }

        public virtual Credential Credential { get; set; }
        public virtual Group Group { get; set; }
    }
}
