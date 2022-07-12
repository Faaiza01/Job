using Job.Controllers;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobWebApi.Controllers
{
    public class JobDashboardController : JobController
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Job Dashbaord";
            var userId = User.Identity.GetUserId();
            //ViewBag.myJobs = genreService.GetUserAppliedJobs(userId);
            //ViewBag.savedJobs = genreService.GetUserSavedJobs(userId);
            dynamic mymodel = new ExpandoObject();
            mymodel.AppliedJobs = genreService.GetUserAppliedJobs(userId);
            mymodel.SavedJobs = genreService.GetUserSavedJobs(userId);
            return View(mymodel);
        }
    }
}
