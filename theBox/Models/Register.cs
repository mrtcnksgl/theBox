using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace theBox.Models
{
    public class Register
    {
        internal string Email;
        internal string UserName;

        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soyadınız")]
        public string Surname { get; set; }

        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        [Required]
        [DisplayName("EPosta")]
        [EmailAddress(ErrorMessage = "Eposta formatında değer giriniz!")]
        public string EMail { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor, tekrar deneyiniz!")]
        public string RePassword { get; set; }
        public object State { get; internal set; }
    }
}