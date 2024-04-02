using HelpDeskAppealManager.Models.Interfaces;

namespace HelpDeskAppealManager.Models.Entities
{
    public class Appeals : IAppeals
    {
        private static List<Appeal> appeals = new List<Appeal>();
        
        public List<Appeal> GetAppeals()
        { 
            return appeals; 
        }

        public void AddAppeal(Appeal appeal)
        {
            appeals.Add(appeal);
        }

        public void SortDeadlineDateDescending()
        {
            appeals = [.. appeals.OrderByDescending(a => a.DeadlineDate)];
        }

        public void RemoveAppeal(int appealId)
        {
            appeals.RemoveAt(appealId);
        }
    }
}
