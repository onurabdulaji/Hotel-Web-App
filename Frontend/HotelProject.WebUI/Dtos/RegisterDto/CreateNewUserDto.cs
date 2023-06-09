using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alani Gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alani Gereklidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanici Adi Alani Gereklidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail Alani Gereklidir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Sifre Alani Gereklidir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sifre Tekrar Alani Gereklidir")]
        public string ConfirmPassword { get; set; }

    }
}
