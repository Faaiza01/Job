using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobWebApi.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Login Page";
            return View();
        }
    }
}
