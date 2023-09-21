using FitnessTracker.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.MVC.Controllers
{
    public class FitnessTrackerController : Controller
    {
        private readonly IFitnessLogService _fitnessLogService;

        public FitnessTrackerController(IFitnessLogService fitnessLogService)
        {
            _fitnessLogService = fitnessLogService;
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> CreateLog(Entities.Entities.FitnessTracker log)
        {
            await _fitnessLogService.CreateLog(log);
            return RedirectToAction(nameof(CreateLog));

        }
    }
}
