using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Data;
using Portfolio.Web.Models;

namespace Portfolio.Web.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public ExperienceViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var experience = _context.Experiences.ToList();
            if (experience == null) { return View(new Experience()); }
            return View(experience);
        }
    }
}
