using System.Web.Mvc;
using SoundBarrierHunting.Domain.Interfaces;

namespace SoundBarrierHunting.Controllers
{
    public class VideoController : Controller
    {
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
    }
}