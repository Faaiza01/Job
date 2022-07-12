using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Job.InServices.IService;
using Job.InServices.Service;


namespace Job.Controllers
{
    public class ServiceController : Controller
    {
        IInboundService service;

        public ServiceController()
        {
            service = new InboundService();
        }

        public ActionResult GetMusicTypes()
        {
            return View(service.GetMusicTypes());
        }
        public ActionResult GetMusicTypesAuthenticated()
        {
            return View("GetMusicTypes", service.GetMusicTypesAuthenticated());
        }
    }
}
