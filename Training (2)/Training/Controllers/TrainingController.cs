using Microsoft.AspNetCore.Mvc;
using Training.Models;

namespace Training.Controllers
{
    public class TrainingController : Controller
    {
       
            public async Task<IActionResult> Index()
            {
                Database db = new Database();
                var mytraining = await db.GetTrainingsAsync();
                return View(mytraining);
            }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MyTrainings training)
        {
            Database db = new Database();
            await db.SaveTraining(training);
            return Redirect("/Training");
        }


    }
}
