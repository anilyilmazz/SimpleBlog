using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{
    //Login.cs  ismi kontrol ile aynı olmalı
    //Login controllerdeki kullanılan login class'ın ismidir.
    public class Login
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType("Password")]
        public string Password { get; set; }
    }
}