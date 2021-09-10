using System.ComponentModel.DataAnnotations;

namespace CSMVC.Models
{
    public class Survey
    {
        [Display(Name = "Your Name: ")]
        [Required(ErrorMessage = "Enter your name")]
        [MinLength(2, ErrorMessage = "Your name must be at least 2 characters.")]
        public string Name { get; set; }
        [Display(Name = "Comments: ")]
        [MaxLength(20, ErrorMessage = "Comment must be no more than 20 characters.")]
        public string Comment { get; set; }

        [MinLength(1)]
        [Display(Name = "Favorite Language: ")]
        [Required(ErrorMessage = "You must chose a favorite language.")]
        public string Language { get; set; }

        [MinLength(1)]
        [Display(Name = "Location: ")]
        [Required(ErrorMessage = "You must chose a location.")]
        public string Location { get; set; }
    }
}