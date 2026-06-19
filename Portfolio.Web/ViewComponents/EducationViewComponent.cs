using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Portfolio.Web.Data;
using Portfolio.Web.Models;

namespace Portfolio.Web.ViewComponents
{
    public class EducationViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public EducationViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var education = _context.Educations.ToList();
            if (education == null)
            {
                return View(new Education());
            }
            return View(education);
        }
    }
}
