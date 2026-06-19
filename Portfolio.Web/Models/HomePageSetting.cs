using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class HomePageSetting
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Hero title")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string HeroTitle { get; set; }
        [DisplayName("Hero name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string HeroName { get; set; }
        [DisplayName("Hero description")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(300, ErrorMessage = "{0} cannot be longer than 300 characters.")]
        public string HeroDescription { get; set; }
        [DisplayName("Hero image")]
        [Required(ErrorMessage = "{0} is required.")]
        public string HeroImageName { get; set; }
        [DisplayName("Hero location")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string HeroLocation { get; set; }
        [DisplayName("Hero status")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string HeroStatus { get; set; }
        [DisplayName("Hero Status")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string HeroFocus { get; set; }
        [DisplayName("Hero language")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string HeroLanguage { get; set; }
        [DisplayName("About title")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string AboutTitle { get; set; }
        [DisplayName("About summary")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string AboutSummary { get; set; }
        [DisplayName("About description")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(500, ErrorMessage = "{0} cannot be longer than 500 characters.")]
        public string AboutDescription { get; set; }
        [DisplayName("Title contact")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string TitleContact { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "{0} is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [DisplayName("Email Url")]
        [Required(ErrorMessage = "{0} is required.")]
        public string EmailUrl { get; set; }
        [DisplayName("Github Url")]
        [Required(ErrorMessage = "{0} is required.")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string GithubUrl { get; set; }
        [DisplayName("Linkedin Url")]
        [Required(ErrorMessage = "{0} is required.")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string LinkedinUrl { get; set; }
        [DisplayName("Meta Title")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string MetaTitle {  get; set; }
        [DisplayName("Meta Description")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(250, ErrorMessage = "{0} cannot be longer than 250 characters.")]
        public string MetaDescription { get; set; }
    }
}
