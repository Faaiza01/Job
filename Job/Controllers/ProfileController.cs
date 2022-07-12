using Job.Controllers;
using Job.Data;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace JobWebApi.Controllers
{
    public class ProfileController : JobController
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Profile";
            var userId = User.Identity.GetUserId();
            ViewBag.userData = genreService.GetLoggedInUserData(userId);
            if (ViewBag.userData == null)
            {
                return RedirectToAction("Index", "Home");
            }            
            return View(ViewBag.userData);
        }

        [HttpPost]
        public ActionResult EditProfile(EditProfileDto editProfileDto,HttpPostedFileBase file)
        {
            try
            {

                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                    file.SaveAs(_path);
                    System.Diagnostics.Debug.WriteLine(_path);
                      editProfileDto.Resume=_path;
                }
              
      
                  
                // 'mo' is the UserId of a User in User table
                // Adding new music object
                var userId = User.Identity.GetUserId();
                genreService.EditProfile(editProfileDto, userId);

                // Redirect to somewhere sensible
                return RedirectToAction("Index", "Home");
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
          

    }
}
