using Job.Services.IService;
using Job.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Job.Controllers
{
    public class MusicController : Controller
    {
        private IMusicService musicService;

        public MusicController()
        {
            musicService = new MusicService();
        }

        //public ActionResult GetMusic(int id)
        //{
        //    Helper helper = new Helper();
        //    ViewBag.GenreID = helper.GetGenreByMusicID(id);

        //    return View(musicService.GetMusic(id));
        //}

        // GET: Music
        public ActionResult Index()
        {
            return View();
        }
    }
}