using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password should be between 6 and 20 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password and Verify must match!")]
        public string VerifyPassword { get; set; }

    }
}
