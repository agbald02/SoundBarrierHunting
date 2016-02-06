using SoundBarrierHunting.Domain.Entities;
using SoundBarrierHunting.Domain.Interfaces;
using System.Collections.Generic;

namespace SoundBarrierHunting.Domain.Concrete
{
    public class VideoRepository : IVideoRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Video> Videos
        {
            get { return context.Videos; }
        }
    }
}
