using HelpDeskAppealManager.Models.Entities;

namespace HelpDeskAppealManager.Models
{
    public class AppealsViewModel
    {
        public List<Appeal>? Appeals { get; set; }
        public string? Description { get; set; }
        public DateTime DeadlineDate { get; set; } = DateTime.Now;
    }
}
