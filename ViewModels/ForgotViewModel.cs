using System.ComponentModel.DataAnnotations;

namespace Blog_Demo.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
