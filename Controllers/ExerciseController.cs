using Microsoft.AspNetCore.Mvc;
using Training.Models;

namespace Training.Controllers
{
    public class ExerciseController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Database db = new Database();
            var exercises = await db.GetOvningarAsync();
            return View(exercises);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Ovning ovning)
        {
            Database db = new Database();
            await db.SaveExercise(ovning);
            return Redirect("/Exercise");
        }

    }
}
