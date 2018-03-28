using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class PostsController : Controller
    {
       public ActionResult Index()
        {
            return View();
            //return Content("<title>Hello World </title> <h1>Merhaba Dünya</h1> <hr> <input></input>");

        }  
    }
}