using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.title = context.Abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.subdescription = context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.Detail = context.Abouts.Select(x => x.Detail).FirstOrDefault();

            var skills = context.Skills.ToList();
            return View(skills);
        }
    }
}
