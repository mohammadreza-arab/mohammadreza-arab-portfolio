using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class LearningItem
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Title")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string Title { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(250, ErrorMessage = "{0} cannot be longer than 250 characters.")]
        public string Description { get; set; }
        [DisplayName("Status")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string Status { get; set; }
    }
}
