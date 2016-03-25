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
        private EFDbContext db = new EFDbContext();
        private IProductRepository repository;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ActionResult Products()
        {
            return View();
        }
    }
}
