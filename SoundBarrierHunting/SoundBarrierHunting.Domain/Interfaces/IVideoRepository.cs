using System.Collections.Generic;
using SoundBarrierHunting.Domain.Entities;

namespace SoundBarrierHunting.Domain.Interfaces
{
    public interface IVideoRepository
    {
        IEnumerable<Video> Videos { get; }
    }
}
