using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{

    //Login controllerdeki kullanılan login class'ın ismidir.
    public class Login
    {
        public string UserName { get; set; }
        [DataType("Password")]
        public string Password { get; set; }
    }
}