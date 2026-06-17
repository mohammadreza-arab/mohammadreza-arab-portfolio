using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class Certificate
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Title")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string Title { get; set; }
        [DisplayName("Issuer")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} cannot be longer than 100 characters.")]
        public string Issuer { get; set; }
        [DisplayName("Year")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than 50 characters.")]
        public string Year { get; set; }
        [DisplayName("Image")]
        [Required(ErrorMessage = "{0} is required.")]
        public string ImageName { get; set; }


    }
}
