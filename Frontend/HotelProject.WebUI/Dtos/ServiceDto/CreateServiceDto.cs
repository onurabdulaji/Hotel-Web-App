using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet Ikon Linki Giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Basligi  Giriniz")]
        [StringLength(100,ErrorMessage ="Hizmet basligi en fazla 100 karakter olabilir.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
