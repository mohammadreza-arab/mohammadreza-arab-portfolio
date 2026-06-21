using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Data;
using Portfolio.Web.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Portfolio.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomePageSettingController : Controller
    {
        private readonly AppDbContext _context;
        public HomePageSettingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var homePageSetting = _context.HomePageSettings.FirstOrDefault();
            if (homePageSetting == null) { return View(new HomePageSetting()); }
            return View(homePageSetting);
        }
        [HttpGet]
        public IActionResult Create()

        {
            var homePageSetting = _context.HomePageSettings.FirstOrDefault();
            if (homePageSetting != null)
            {
                return RedirectToAction(nameof(Edit), new { id = homePageSetting.Id });

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HomePageSetting homePageSetting,  IFormFile? HeroImageFile)
        {
            var homePage = _context.HomePageSettings.FirstOrDefault();
            if (homePage != null) 
            {
                return RedirectToAction(nameof(Edit), new { id = homePageSetting.Id });
            }
            if (HeroImageFile != null)
            {
                var fileName = Guid.NewGuid() + Path.GetExtension(HeroImageFile.FileName);

                var path = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot/images/hero",
                    fileName);

                using var stream = new FileStream(path, FileMode.Create);

                 HeroImageFile.CopyTo(stream);

                homePageSetting.HeroImageName = fileName;
            }
            _context.HomePageSettings.Add(homePageSetting);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index)); ;
        }
        [HttpGet]
        public IActionResult Edit()
        {
            var homePageSetting = _context.HomePageSettings.FirstOrDefault();
            if (homePageSetting == null) { return RedirectToAction(nameof(Create)); }
            return View(homePageSetting);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HomePageSetting homePageSetting, IFormFile? HeroImageFile)
        {
            var homePage = _context.HomePageSettings.FirstOrDefault();
            if (homePage == null) { return RedirectToAction(nameof(Create)); }
            homePage.HeroTitle= homePageSetting.HeroTitle;
            homePage.HeroName= homePageSetting.HeroName;
            homePage.HeroDescription= homePageSetting.HeroDescription;
            homePage.HeroFocus= homePageSetting.HeroFocus;
            homePage.HeroStatus= homePageSetting.HeroStatus;
            homePage.HeroLanguage= homePageSetting.HeroLanguage;
            homePage.HeroLocation= homePageSetting.HeroLocation;
            homePage.AboutTitle= homePageSetting.AboutTitle;
            homePage.AboutSummary= homePageSetting.AboutSummary;
            homePage.AboutDescription= homePageSetting.AboutDescription;
            homePage.Email= homePageSetting.Email;
            homePage.EmailUrl= homePageSetting.EmailUrl;
            homePage.LinkedinUrl= homePageSetting.LinkedinUrl;
            homePage.TitleContact= homePageSetting.TitleContact;
            homePage.TitleContact=homePageSetting.TitleContact;
            if (HeroImageFile != null)
            {
                var fileName = Guid.NewGuid() +
                               Path.GetExtension(HeroImageFile.FileName);

                var path = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot/images/hero",
                    fileName);

                using var stream = new FileStream(path, FileMode.Create);

                 HeroImageFile.CopyTo(stream);

                
                homePage.HeroImageName = fileName;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
