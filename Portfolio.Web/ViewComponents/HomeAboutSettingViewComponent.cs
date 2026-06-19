using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Data;
using Portfolio.Web.Models;

namespace Portfolio.Web.ViewComponents
{
    public class HomeAboutSettingViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public HomeAboutSettingViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {

            var setting = _context.HomePageSettings.FirstOrDefault();
            if (setting == null)
            {
                return View(new HomePageSetting());
            }
            return View(setting);
        }
    }
}
