using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class RegistrationJourney
    {
        public int GroupId { get; set; }
        public string Source { get; set; }
        public byte RegistrationFormVariant { get; set; }

        public virtual Group Group { get; set; }
    }
}
