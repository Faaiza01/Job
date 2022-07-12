using Job.Data.Models.Domain;
using Job.Services.IService;
using Job.Services.Models;
using Job.Services.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Job.Controllers
{
    public class HomeController : Controller
    {
        private IMusicService musicService;

        public HomeController()
        {
            //helper = new Helper();
            //genreService = new GenreService(); Will use from JobController
            //artistService = new ArtistService();

            musicService = new MusicService();
        }
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            App_User app_User = musicService.GetUserData(userId);
            Session["Data"] = app_User;
            if (userId != null)
            {
                return View();
            }

            return RedirectToAction("Index", "Login");
            ;
        }

        public ActionResult DownloadTerms()
        {
            return File("~/Content/Documents/_BusinessTerms.pdf", "application/pdf", "_BusinessTerms");
        }

        // POST: MusicAdmin/Create
        [HttpPost]
        public ActionResult PostJob(PostJobDto postJobDto)
        {
            try
            {
                //// 'mo' is the UserId of a User in User table
                musicService.AddJob(postJobDto, "mo");

                //// Redirect to somewhere sensible
                //return RedirectToAction("GetGenre", "Genre", new { id = musicGenreArtist.Genre });
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                var test = ex.Message;
                return View();
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}