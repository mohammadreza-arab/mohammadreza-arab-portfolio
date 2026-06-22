using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Data;
using Portfolio.Web.Models;

namespace Portfolio.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillCategoryController : Controller
    {
        private readonly AppDbContext _context;
        public SkillCategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.SkillCategorys
       .Include(x => x.Skills)
       .ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SkillCategory skillCategory)
        {
            if (!ModelState.IsValid)
            {
                return View(skillCategory);
            }
            _context.SkillCategorys.Add(skillCategory);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _context.SkillCategorys.FirstOrDefault(x => x.Id == id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(SkillCategory skillCategory)
        {
            if (!ModelState.IsValid)
            {
                return View(skillCategory);
            }
            var result = _context.SkillCategorys.FirstOrDefault(x => x.Id == skillCategory.Id);
            result.Name = skillCategory.Name;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = _context.SkillCategorys.FirstOrDefault(x => x.Id == id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(SkillCategory skillCategory)
        {
            var result = _context.SkillCategorys.FirstOrDefault(x => x.Id == skillCategory.Id);
            _context.SkillCategorys.Remove(result);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
