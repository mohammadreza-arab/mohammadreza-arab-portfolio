using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Data;
using Portfolio.Web.Models;
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
