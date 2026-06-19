using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Data;
using Portfolio.Web.Models;

namespace Portfolio.Web.ViewComponents
{
    public class SkillCategoryViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public SkillCategoryViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _context.SkillCategorys
       .Include(x => x.Skills)
       .ToList();
            if (categories == null)
            {
                return View(new SkillCategory());
            }
            return View(categories);
        }
    }
}
