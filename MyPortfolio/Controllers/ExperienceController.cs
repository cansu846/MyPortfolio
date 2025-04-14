using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;
using MyPortfolio.Dal.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Experineces.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience e)
        {
           context.Experineces.Add(e);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var value = context.Experineces.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience e)
        {
            context.Experineces.Update(e);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteExperience(int id)
        {
            context.Experineces.Remove(context.Experineces.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
