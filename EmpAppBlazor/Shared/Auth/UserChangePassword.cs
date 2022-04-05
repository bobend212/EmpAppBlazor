using System.ComponentModel.DataAnnotations;

namespace EmpAppBlazor.Shared.Auth
{
    public class UserChangePassword
    {
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage = "The password do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}