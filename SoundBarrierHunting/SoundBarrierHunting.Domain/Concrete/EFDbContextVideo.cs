using SoundBarrierHunting.Domain.Entities;
using System.Data.Entity;

namespace SoundBarrierHunting.Domain.Concrete
{
    public class EFDbContextVideo : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}
