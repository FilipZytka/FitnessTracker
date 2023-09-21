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
        public async Task <IActionResult> Create(Entities.Entities.FitnessTracker log)
        {
            if (!ModelState.IsValid)
            {
                return View(log);

            } 
            await _fitnessLogService.Create(log);
            return RedirectToAction(nameof(Create));

        }
    }
}
