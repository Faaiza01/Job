using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobWebApi.Controllers
{
    public class PostJobController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Post a Job";

            return View();
        }
    }
}
