﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Hizmet İkon Linki giriniz")]
        public string ServiceIcon { get; set; }


        [Required(ErrorMessage = "Hizmet Başlığı giriniz")]
        [StringLength(100, ErrorMessage ="Hizmet Başlığı en fazla 100 Karakter olabilir")]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
