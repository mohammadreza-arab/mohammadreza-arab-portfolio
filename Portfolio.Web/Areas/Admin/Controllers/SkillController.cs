using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Data;
using Portfolio.Web.Models;
using Portfolio.Web.ViewModels;

namespace Portfolio.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;

        public SkillController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var skill = _context.Skill
      .Include(x => x.Category)
      .ToList();
            return View(skill);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var vm = new SkillCreateViewModel();
            vm.Categories = _context.SkillCategorys.Select
                (
                x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }
                ).ToList();


            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SkillCreateViewModel vm)
        {
            var skill = new Skill
            {
                SkillsTitle = vm.SkillsTitle,
                SkillCategoryId = vm.SkillCategoryId
            };

            _context.Skill.Add(skill);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var skill = _context.Skill
            .FirstOrDefault(x => x.Id == id);
            SkillUpdateViewModel vm = new()
            {
                Id = skill.Id,
                SkillsTitle = skill.SkillsTitle,
                SkillCategoryId = skill.SkillCategoryId,

             Categories = _context.SkillCategorys
            .Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList()
            };
         return View(vm);  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SkillUpdateViewModel vm)
        {
            var skill = _context.Skill.FirstOrDefault(x => x.Id == vm.Id);
            skill.SkillsTitle = vm.SkillsTitle;
            skill.SkillCategoryId = vm.SkillCategoryId;

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var skill = _context.Skill.Find(id);
            return View(skill);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var skill = _context.Skill.Find(id);

            if (skill == null)
                return NotFound();

            _context.Skill.Remove(skill);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
