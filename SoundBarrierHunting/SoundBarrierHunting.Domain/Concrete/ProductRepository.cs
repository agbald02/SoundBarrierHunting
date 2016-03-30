using SoundBarrierHunting.Domain.Entities;
using SoundBarrierHunting.Domain.Interfaces;
using System.Collections.Generic;

namespace SoundBarrierHunting.Domain.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private EFDbContextProduct context = new EFDbContextProduct();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
