using HelpDeskAppealManager.Models;
using HelpDeskAppealManager.Models.Entities;
using HelpDeskAppealManager.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskAppealManager.Controllers
{
    public class AppealsController : Controller
    {
        private readonly IAppeals _appeals;

        public AppealsController(IAppeals appeals)
        {
            _appeals = appeals;
        }

        [HttpGet]
        public IActionResult List()
        {
            var appeals = _appeals.GetAppeals();
            foreach(var appeal in appeals)
            {
                // If the deadline is due or less than 1 hour left, color the text red
                appeal.Color = (appeal.DeadlineDate - DateTime.Now).Hours < 1 ? "color:red" : "color:black";
            }
            AppealsViewModel model = new AppealsViewModel();
            model.Appeals = appeals;
            return View(model); 
        }

        [HttpPost]
        public IActionResult Add(AppealsViewModel viewModel)
        {
            var appeal = new Appeal
            {
                Description = viewModel.Description,
                EntryDate = DateTime.Now,
                DeadlineDate = viewModel.DeadlineDate,
                Color = "color:black"
            };

            _appeals.AddAppeal(appeal);

            _appeals.SortDeadlineDateDescending();

            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Remove(int appealId)
        {
            _appeals.RemoveAppeal(appealId);
            return RedirectToAction("List");
        }
    }
}
