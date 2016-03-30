using System.Collections.Generic;
using SoundBarrierHunting.Domain.Entities;
using System.Web.Mvc;

namespace SoundBarrierHunting.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}