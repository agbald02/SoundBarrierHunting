using System.Collections.Generic;
using SoundBarrierHunting.Domain.Entities;
using System.Web.Mvc;

namespace SoundBarrierHunting.Models.ViewModels
{
    public class VideosListViewModel
    {
        public IEnumerable<Video> Videos { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}