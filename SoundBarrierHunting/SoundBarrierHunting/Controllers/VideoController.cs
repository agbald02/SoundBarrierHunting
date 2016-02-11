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
        public int pageSize = 8;

        public VideoController(IVideoRepository videoRepository)
        {
            this.repository = videoRepository;
        }

        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult Search(string videoCategory)
        {
            var videoCatList = new List<string>();

            var CatQuery = from c in db.Videos
                           orderby c.Category
                           select c.Category;

            videoCatList.AddRange(CatQuery.Distinct());
            ViewBag.videoCategories = new SelectList(db.Videos
                            .OrderBy(c => c.Category)
                            .Select(c => c.Category)
                            .Distinct());

            var videoList = from v in db.Videos
                            select v;

            if (!string.IsNullOrEmpty(videoCategory))
            {
                videoList = videoList.Where(x => x.Category == videoCategory);
            }

            return View(videoCategory);
        }

        public ViewResult AllVideos(string videoCategory, int page = 1)
        {
            var search = Search(videoCategory);

            VideosListViewModel model = new VideosListViewModel
            {
                Videos = repository.Videos
                .OrderBy(v => v.ID)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Videos.Count()
                }
            };

            return View(model);
        }
    }
}