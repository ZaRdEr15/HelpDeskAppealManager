using System.Drawing;

namespace HelpDeskAppealManager.Models.Entities
{
    public class Appeal
    {
        public string? Description { get; set; }
        // EntryDate is created automatically whenever
        // the user creates a new appeal
        public DateTime EntryDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string? Color { get; set; }
    }
}
