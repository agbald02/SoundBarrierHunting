using SoundBarrierHunting.Domain.Entities;
using System.Data.Entity;

namespace SoundBarrierHunting.Domain.Concrete
{
    public class EFDbContextProduct : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
