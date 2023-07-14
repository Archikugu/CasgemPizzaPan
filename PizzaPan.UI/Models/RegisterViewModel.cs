using System.ComponentModel.DataAnnotations;

namespace PizzaPan.UI.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string Name { get; set; }
        public string Surname { get; set; }

        [Required(ErrorMessage = "E mail alanı boş geçilemez")]
        public string Email { get; set; }
        public string Username { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
