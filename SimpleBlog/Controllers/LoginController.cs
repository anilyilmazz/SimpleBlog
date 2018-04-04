using SimpleBlog.Controllers;
using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Text;

namespace SimpleBlog.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //return Content("Login page!");
        }
        [HttpPost]
        public ActionResult Index(Login form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            
           
            return Content("Your İnformation<br>"+form.UserName+"<br>"+form.Password);
        }
    }
}