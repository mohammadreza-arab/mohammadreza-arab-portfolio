using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Data;
using Portfolio.Web.Models;

namespace Portfolio.Web.ViewComponents
{
    public class LearningItemViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public LearningItemViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var learning = _context.LearningItems.ToList();
            if (learning == null)
            {
                return View(new LearningItem());
            }
            return View(learning);
        }
    }
}
