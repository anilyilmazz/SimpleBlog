using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult Index()
        {
            return Content("Orders controller Index Action.");
        }
        public ActionResult Update()
        {
            return Content("Orders controller Update Action.");
        }
    }
}