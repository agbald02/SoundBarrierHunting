using SoundBarrierHunting.Domain.Entities;
using System.Data.Entity;

namespace SoundBarrierHunting.Domain.Concrete
{
    public class EFDbContextWebsite : DbContext
    {
        public DbSet<Product> Products { get; set; }


        public DbSet<Video> Videos { get; set; }
    }
}
