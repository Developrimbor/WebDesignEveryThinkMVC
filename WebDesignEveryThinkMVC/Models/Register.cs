using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDesignEveryThinkMVC.Models
{
    public class Register
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soyadınız")]
        public string Surname { get; set; }

        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("E-posta")]
        [EmailAddress(ErrorMessage = "Doğru eposta adresi giriniz!")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Tekrar Şifre")]
        [Compare("Password", ErrorMessage = "Şifre uyuşmuyor!")]
        public string RePassword { get; set; }
    }
}