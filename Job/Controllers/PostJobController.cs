using Job.Services.IService;
using Job.Services.Models;
using Job.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Job.Controllers
{
    public class PostJobController : Controller
    {
        private IMusicService musicService;

        public PostJobController()
        {
            //helper = new Helper();
            //genreService = new GenreService(); Will use from JobController
            //artistService = new ArtistService();
            musicService = new MusicService();
        }
        public ActionResult Index()
        {
            return View();
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
      
    }
}