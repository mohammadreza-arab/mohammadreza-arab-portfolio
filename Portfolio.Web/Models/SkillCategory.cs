using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class SkillCategory
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string Name { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}
