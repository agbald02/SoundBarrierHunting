using SoundBarrierHunting.Domain.Entities;
using System.Data.Entity;

namespace SoundBarrierHunting.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}
