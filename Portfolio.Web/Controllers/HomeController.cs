using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Portfolio.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
