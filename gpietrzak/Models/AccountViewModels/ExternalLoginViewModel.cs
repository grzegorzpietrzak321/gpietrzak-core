using System.ComponentModel.DataAnnotations;

namespace gpietrzak.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
