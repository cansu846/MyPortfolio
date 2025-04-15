using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;
using MyPortfolio.Dal.Entities;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public IActionResult DetailMessage(int id)
        {
            var values = context.Messages.Find(id);
            return View(values);
        }
        

        public IActionResult ChangeIsReadTrue(int id)
        {
            var values = context.Messages.Find(id);
            values.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

       
        public IActionResult ChangeIsReadFalse(int id)
        {
            var values = context.Messages.Find(id);
            values.IsRead = false;
            context.SaveChanges();  
            return RedirectToAction("Index");
        }

   
        [HttpGet]
        public IActionResult DeleteMessage(int id)
        {
            context.Messages.Remove(context.Messages.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
