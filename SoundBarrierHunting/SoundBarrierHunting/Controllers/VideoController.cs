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
        private EFDbContextVideo db = new EFDbContextVideo();
        private IVideoRepository repository;

        public VideoController(IVideoRepository videoRepository)
        {
            this.repository = videoRepository;
        }

        public ActionResult Videos()
        {
            return View();
        }

        public ViewResult AllVideos()
        {
            return View(repository.Videos);
        }
        public ViewResult SoundBarrierInfo()
        {
            return View(repository.Videos);
        }
        public ViewResult EssentialHuntingTips()
        {
            return View(repository.Videos);
        }
        public ViewResult RulesOfSoundConcealment()
        {
            return View(repository.Videos);
        }
        public ViewResult HuntsAndWebisodes()
        {
            return View(repository.Videos);
        }

        public ViewResult TheRut()
        {
            return View(repository.Videos);
        }

        public ViewResult WhitetailHearingScience()
        {
            return View(repository.Videos);
        }
    }
}