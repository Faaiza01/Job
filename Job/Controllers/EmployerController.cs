using Job.Data.Models.Domain;
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
    public class EmployerController : JobController
    {
        private Helper helper;
        //private IGenreService genreService; Using from JobController
        private IArtistService artistService;
        private IMusicService musicService;


        public EmployerController()
        {
            helper = new Helper();
            //genreService = new GenreService(); Will use from JobController
            artistService = new ArtistService();
            musicService = new MusicService();
     

        }

        // GET: MusicAdmin
        public ActionResult Index()
        {
            ViewBag.applicants = genreService.GetListOfApplicants();

            return View(ViewBag.genres);
        }

        // GET: MusicAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //GET: MusicAdmin/Edit
        public ActionResult EditJob(int id)
        {
            PostJobDto postJobDto = new PostJobDto();
            Employer job = musicService.GetJob(id);


            postJobDto.JobTitle = job.JobTitle;
            postJobDto.JobDescription = job.JobDescription;
            postJobDto.JobCategory = job.JobCategory;
            postJobDto.Salary = job.Salary;
            postJobDto.CompanyName = job.CompanyName;
            postJobDto.CompanyAddress = job.CompanyAddress;
            postJobDto.ComapanyEmail = job.ComapanyEmail;
            postJobDto.CompanyWebsite = job.CompanyWebsite;

            //ViewBag.genreID = musicGenreArtist.Genre;
            //ViewBag.genreList = helper.GetGenreDropDownByMusicId(id);
            //ViewBag.artistList = helper.GetArtistDropDownByMusicId(id);

            return View(postJobDto);
        }

        [HttpPost]
        public ActionResult EditJob(int id, PostJobDto postJobDto)
        {
            try
            {

                // 'mo' is the UserId of a User in User table
                // Adding new music object
                musicService.EditJob(postJobDto, "mo", id);

                // Redirect to somewhere sensible
                return RedirectToAction("Index", "Employer");
                //return RedirectToAction("Index");
            }
            catch
            {
                //ViewBag.genreList = helper.GetGenreDropDownByMusicId(id);
                //ViewBag.artistList = helper.GetArtistDropDownByMusicId(id);
                return View();
            }
        }

        //// GET: MusicAdmin/Create
        public ActionResult AddMusic()
        {
            //ViewBag.genreList = helper.GetGenreDropDown();
            //ViewBag.artistList = helper.GetArtistDropDown();

            //ViewBag.genreList = helper.GetSelectList<Genre>(
            //    genreService.GetGenres(), x => x.ID, x => x.Name);
            //ViewBag.artistList = helper.GetSelectList<Artist>(
            //    artistService.GetArtists(), x => x.ID, x => x.Name);

            return View();
        }

        //// POST: MusicAdmin/Create
        [HttpPost]
        public ActionResult AddMusic(MusicGenreArtist musicGenreArtist)
        {
            try
            {
                // 'mo' is the UserId of a User in User table
                //musicService.AddMusic(musicGenreArtist, "mo");

                // Redirect to somewhere sensible
                return RedirectToAction("GetGenre", "Genre", new { id = musicGenreArtist.Genre });
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
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
            catch (Exception ex)
            {
                var test = ex.Message;
                return View();
            }
        }

        //// GET: MusicAdmin/Delete/5
        public ActionResult DeleteJob(int id)
        {
            Employer job = musicService.GetJob(id);
            return View(job);
        }

        //// POST: MusicAdmin/Delete/5
        [HttpPost]
        public ActionResult DeleteJob(int id, Employer music)
        {
            try
            {
                musicService.DeleteJob(id);

                return RedirectToAction("Index", new { Controller = "Employer" });
            }

            catch
            {
                return View();
            }
        }
    }
}
