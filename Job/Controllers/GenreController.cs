using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Job.Services.Service;
using Job.Services.IService;
using Job.Data.Models.Domain;
using Job.InServices.IService;
using Job.InServices.Service;
using Job.InServices.ProxyToJobWebService;

namespace Job.Controllers
{
    public class GenreController : JobController
    {
        //private IGenreService genreService;
        public GenreController()
        {
           //genreService = new GenreService();            
        }
        public ActionResult GetGenres()
        {
            return View(ViewBag.genres);
            //return View(genreService.GetGenres());
        }
        //public ActionResult GetGenre(int id)
        //{
        //    ViewBag.GenreID = id;
        //    return View(genreService.GetGenre(id));
        //}
        //public ActionResult GetMusics(int id)
        //{
        //    return View(genreService.GetGenre(id).Musics.ToList());
        //}
        public ActionResult Index()
        {
            return View();
        }
    }
}