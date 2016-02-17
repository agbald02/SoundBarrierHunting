using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using SoundBarrierHunting.Domain.Concrete;
using SoundBarrierHunting.Domain.Interfaces;
using SoundBarrierHunting.Models.ViewModels;
using SoundBarrierHunting.Models;
using System.Collections.Generic;
using System;

namespace SoundBarrierHunting.Controllers
{
    public class VideoController : Controller
    {
        private EFDbContext db = new EFDbContext();
        private IVideoRepository repository;

        public VideoController(IVideoRepository videoRepository)
        {
            this.repository = videoRepository;
        }

        public ActionResult Videos()
        {
            return View();
        }

        public ViewResult AllVideos(int page = 1)
        {
            return View(repository.Videos);
        }
    }
}