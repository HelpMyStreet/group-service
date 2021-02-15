using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    
    public class SupportActivityConfiguration
    {
        public int SupportActivityId { get; set; }
        public bool AutoSignUpWhenOtherSelected { get; set; }
    }
}
