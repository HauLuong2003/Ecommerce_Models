using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Models.Model.Request
{
    public class ResetPassword
    {
        [Required]
        public string Token { get; set; } =  string.Empty;
        [Required]
        public string Password {  get; set; } =string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
