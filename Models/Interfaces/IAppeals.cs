using HelpDeskAppealManager.Models.Entities;

namespace HelpDeskAppealManager.Models.Interfaces
{
    public interface IAppeals
    {
        List<Appeal> GetAppeals();
        void AddAppeal(Appeal appeal);
        void SortDeadlineDateDescending();
        void RemoveAppeal(int appealId);
    }
}
