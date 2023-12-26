using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDesignEveryThinkMVC.Models
{
    public class ShippingDetails
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Adres Tanımını Giriniz! ")]
        public string AddressTitle { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Adres Tanımını Giriniz! ")]
        public string AddressLine { get; set; }

        [Required(ErrorMessage = "Lütfen Şehir Giriniz! ")]
        public string City { get; set; }

        [Required(ErrorMessage = "Lütfen İlçe Giriniz! ")]
        public string Town { get; set; }

        public string ZipCode { get; set; }
    }
}