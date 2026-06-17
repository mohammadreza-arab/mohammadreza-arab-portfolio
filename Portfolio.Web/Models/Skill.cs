using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Web.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Skill Title")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string SkillsTitle { get; set; }
        public SkillCategory Category { get; set; }
        [ForeignKey(nameof(SkillCategory))]
        public int SkillCategoryId { get; set; }
    }
}
