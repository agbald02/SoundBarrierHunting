using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoundBarrierHunting.Models;

namespace SoundBarrierHunting.Controllers
{
    public class VideoController : Controller
    {
            //new Video{ 
            //        VideoId = 1,
            //        VideoLink = "https://www.youtube.com/embed/66ImvhrhuHc"},
            //new Video{
            //        VideoId = 2,
            //        VideoLink = "https://www.youtube.com/embed/4gK8jmXqtdk"}


        //public ActionResult Videos(int id = 1)
        //{
            //Video link = videoLinks.Where(v => v.VideoId == id).First();
            //return View(link);
        //}

        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult AllVideos()
        {
            return View();
        }
    }
}