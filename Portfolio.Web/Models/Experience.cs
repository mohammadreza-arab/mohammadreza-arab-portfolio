using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Year")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than 50 characters.")]
        public  string Year {  get; set; }
        [DisplayName("Title")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string Title { get; set; }
        [DisplayName("Company Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string CompanyName { get; set; }
        [DisplayName("Company Url")]
        [Required(ErrorMessage = "{0} is required.")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string CompanyUrl { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(250, ErrorMessage = "{0} cannot be longer than 250 characters.")]
        public string Description { get; set; }
        [DisplayName("Work Info")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string WorkInfo { get; set; }

    }
}
