using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Hero Title")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string Title { get; set; }
        [DisplayName("Hero Description")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(300, ErrorMessage = "{0} cannot be longer than 300 characters.")]
        public string Description { get; set; }
        [DisplayName(" Image")]
        [Required(ErrorMessage = "{0} is required.")]
        public string ImageName { get; set; }
        [DisplayName("GitHub url")]
        [Required(ErrorMessage = "{0} is required.")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string GitHubUrl { get; set; }
        [DisplayName("Live demo url")]
        [Required(ErrorMessage = "{0} is required.")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string LiveDemoUrl { get; set; }
    }
}
