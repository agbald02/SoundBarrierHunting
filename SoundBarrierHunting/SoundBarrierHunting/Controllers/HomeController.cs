using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoundBarrierHunting.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Home()
        {
            return View("_Home");
        }
        public ViewResult About()
        {
            return View("_AboutHome");
        }
        public ViewResult Products()
        {
            return View("_ProductsHome");
        }
        public ViewResult Articles()
        {
            return View("_ArticlesHome");
        }
        public ViewResult Videos()
        {
            return View("_VideosHome");
        }
    }
}