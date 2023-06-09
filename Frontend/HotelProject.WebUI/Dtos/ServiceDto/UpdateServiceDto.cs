using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet Ikon Linki Giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Basligi  Giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet basligi en fazla 100 karakter olabilir.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Aciklamasi  Giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet aciklamasi en fazla 500 karakter olabilir.")]
        public string Description { get; set; }
    }
}
