using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;
using MyPortfolio.Dal.Entities;

namespace MyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddToDoList(ToDoList e)
        {
            context.ToDoLists.Add(e);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusTrue(int id)
        {
            var values = context.ToDoLists.Find(id);
            values.Status= true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult ChangeStatusFalse(int id)
        {
            var values = context.ToDoLists.Find(id);
            values.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteToDo(int id)
        {
            context.ToDoLists.Remove(context.ToDoLists.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
