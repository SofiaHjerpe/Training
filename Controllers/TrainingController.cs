using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            Database db = new Database();
            var exercises = await db.GetOvningarAsync();
            var viewModel = new CreateTrainingViewModel()
            {
                Exercises = exercises,
            };
            return View(viewModel);

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
