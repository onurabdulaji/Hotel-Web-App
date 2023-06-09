using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LogInDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanici Adi Giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Sifre Giriniz")]
        public string Password { get; set; }
    }
}
