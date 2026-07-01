using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.ViewModels
{
    public class SkillCreateViewModel
    {
        [DisplayName("Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string SkillsTitle { get; set; }

        [DisplayName("Category")]
        [Required]
        public int SkillCategoryId { get; set; }
        public List<SelectListItem> Categories { get; set; } = new();

    }
}
