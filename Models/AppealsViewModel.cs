using HelpDeskAppealManager.Models.Entities;
using System;

namespace HelpDeskAppealManager.Models
{
    public class AppealsViewModel
    {
        public List<Appeal>? Appeals { get; set; }
        public string? Description { get; set; }
        public DateTime DeadlineDate { get; set; }
    }
}
