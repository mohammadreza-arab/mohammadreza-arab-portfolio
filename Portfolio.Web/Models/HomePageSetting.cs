using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class HomePageSetting
    {
        public int Id { get; set; }
        public string HeroTitle { get; set; }
        public string HeroName { get; set; }
        public string HeroDescription { get; set; }
        public string HeroImage { get; set; }
        public string HeroLocation { get; set; }
        public string HeroStatus { get; set; }
        public string HeroFocus { get; set; }
        public string HeroLanguage { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
        public string AboutShortDescription { get; set; }
        public string TitleContact { get; set; }
        public string Email { get; set; }
        public string EmailUrl { get; set; }
        public string GithubUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string ResumeUrl { get; set; }
    }
}
