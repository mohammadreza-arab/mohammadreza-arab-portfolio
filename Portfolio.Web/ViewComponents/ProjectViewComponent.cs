using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Data;
using Portfolio.Web.Models;

namespace Portfolio.Web.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public ProjectViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var project = _context.Projects.ToList();
            if (project == null)
            {
                return View(new Project());
            }
            return View(project);
        }
    }
}
