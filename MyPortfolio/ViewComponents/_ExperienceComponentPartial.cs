using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Experineces.ToList();
            return View(values);  
        }
    }
}
