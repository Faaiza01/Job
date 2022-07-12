using Job.Controllers;
using Job.Data;
using Job.Data.Models.Domain;
using Job.Services.IService;
using Job.Services.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobWebApi.Controllers
{
    public class SearchController : JobController
    {
        private IMusicService musicService;
        public IGenreService genreService;

        public SearchController()
        {
            //helper = new Helper();
            //genreService = new GenreService(); Will use from JobController
            //artistService = new ArtistService();
            musicService = new MusicService();
            genreService = new GenreService();
            //string UserId = User.Identity.GetUserId();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Search";
            var userId = User.Identity.GetUserId();
      
            ViewBag.jobs = genreService.GetAppliedJobs(userId);
          
            return View(ViewBag.jobs);
        }

        public ActionResult ApplyJob(int id)
        {
            var userId = User.Identity.GetUserId();

            AppliedJobs appliedJobs = new AppliedJobs
            {
                JobId = id,
                UserIdentityId = userId,
                AppliedJobDate = DateTime.Now,
            };

            musicService.ApplyJob(appliedJobs);
            return RedirectToAction("Index", "Search"); ;
        }

        public ActionResult SaveJob(int id)
        {
            var userId = User.Identity.GetUserId();

            SavedJobs appliedJobs = new SavedJobs
            {
                JobId = id,
                UserIdentityId = userId,
            };
            musicService.SaveJob(appliedJobs);
            return RedirectToAction("Index", "Search"); ;
        }

        [HttpPost]
        public ActionResult Index(string JobTitle)
        {
            var userId = User.Identity.GetUserId();
           
            ViewBag.jobs= genreService.SearchByJobTitle(JobTitle, userId);
          
            
            return View(ViewBag.jobs);
          
        }
       

    }
}
