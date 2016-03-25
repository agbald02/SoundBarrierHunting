using System.Collections.Generic;
using SoundBarrierHunting.Domain.Entities;

namespace SoundBarrierHunting.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
