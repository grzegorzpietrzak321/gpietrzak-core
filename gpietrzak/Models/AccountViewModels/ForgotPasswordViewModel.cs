using System.ComponentModel.DataAnnotations;

namespace gpietrzak.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
