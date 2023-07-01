using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Hizmet İkon Linki giriniz")]
        public string ServiceIcon { get; set; }


        [Required(ErrorMessage = "Hizmet Başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet Başlığı en fazla 100 Karakter olabilir")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Hizmet Başlığı giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet Açıklaması en fazla 500 Karakter olabilir")]
        public string Description { get; set; }
    }
}
