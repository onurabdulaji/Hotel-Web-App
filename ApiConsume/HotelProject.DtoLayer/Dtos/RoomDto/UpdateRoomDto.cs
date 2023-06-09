using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Lutfen oda numarasini giriniz !")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lutfen oda gorseli giriniz !")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lutfen fiyat giriniz !")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lutfen oda basligi giriniz !")]
        [StringLength(100,ErrorMessage ="En fazla 100 karakter veri girisi")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lutfen yatak sayisi  giriniz !")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lutfen banyo sayisi  giriniz !")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Lutfen wifi  giriniz !")]
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lutfen aciklama  giriniz !")]
        public string Description { get; set; }
    }
}
