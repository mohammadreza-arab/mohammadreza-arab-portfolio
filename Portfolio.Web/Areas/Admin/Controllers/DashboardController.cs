using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        [Route("Admin/Dashboard/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
