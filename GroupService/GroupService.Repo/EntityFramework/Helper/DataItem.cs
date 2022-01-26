using HelpMyStreet.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Helper
{
    public class DataItem
    {
        public GroupAction GroupAction { get; set; }
        public DateTime Date { get; set; }
        public bool IsAdmin { get; set; }
        public int Count { get; set; }
    }
}
