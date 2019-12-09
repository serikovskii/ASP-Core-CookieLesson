
using System.ComponentModel.DataAnnotations;

namespace WebApplication10.ViewModles
{
    public class AuthViewModel
    {
        [EmailAddress(ErrorMessage = "No correct email")]
        [Required]
        public string Email { get; set; }
        [MinLength(6)]
        [Required]
        public string Password { get; set; }
    }
}
