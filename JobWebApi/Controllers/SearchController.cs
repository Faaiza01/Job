using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobWebApi.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Search";

            return View();
        }
    }
}
