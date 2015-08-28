using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoundBarrierHunting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult About()
        {
            return View("About");
        }
        public ActionResult ProductsHome()
        {
            return View("ProductsHome");
        }
        public ActionResult ArticlesHome()
        {
            return View("ArticlesHome");
        }
        public ActionResult VideosHome()
        {
            return View("VideosHome");
        }
    }
}