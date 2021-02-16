using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class RegistrationFormSupportActivity
    {
        public byte RequestHelpFormVariantId { get; set; }
        public int SupportActivityId { get; set; }
        public string Label { get; set; }
        public byte DisplayOrder { get; set; }
        public bool IsPreSelected { get; set; }
    }
}
