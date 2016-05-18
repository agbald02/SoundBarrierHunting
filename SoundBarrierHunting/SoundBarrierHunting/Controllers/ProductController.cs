using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using SoundBarrierHunting.Domain.Concrete;
using SoundBarrierHunting.Domain.Interfaces;
using SoundBarrierHunting.Models.ViewModels;
using SoundBarrierHunting.Models;
using System.Collections.Generic;
using System;

namespace SoundBarrierHunting.Controllers
{
    public class ProductController : Controller
    {
        private EFDbContextWebsite db = new EFDbContextWebsite();
        private IProductRepository repository;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ActionResult Products()
        {
            ProductListViewModel model = new ProductListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.ID)
            };

            return View(model);
        }
    }
}
