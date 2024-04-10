using HelpDeskAppealManager.Models.Interfaces;

namespace HelpDeskAppealManager.Models.Entities
{
    public class Appeals : IAppeals
    {
        // Static to make it accessible and changeable throught the project run lifetime
        private static List<Appeal> appeals = [];
        
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
            // Order deadline date by descending order using LINQ
            // with sort and reassign in a single line
            appeals = [.. appeals.OrderByDescending(a => a.DeadlineDate)];
        }

        public void RemoveAppeal(int appealId)
        {
            appeals.RemoveAt(appealId);
        }
    }
}
