using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.ViewModels
{
    public class SkillUpdateViewModel
    {
        public int Id { get; set; }

        [Required]
        public string SkillsTitle { get; set; }

        public int SkillCategoryId { get; set; }

        public List<SelectListItem>? Categories { get; set; }
    }
}
