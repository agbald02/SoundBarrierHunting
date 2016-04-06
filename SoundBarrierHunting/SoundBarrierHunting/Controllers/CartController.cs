using System.Linq;
using System.Web.Mvc;
using SoundBarrierHunting.Domain.Interfaces;
using SoundBarrierHunting.Domain.Entities;
using SoundBarrierHunting.Models;

namespace SoundBarrierHunting.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;

        public CartController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult Cart(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                ReturnUrl = returnUrl,
                Cart = cart
            });
        }

        public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ID == productId);

            if(product != null)
            {
                cart.AddItem(product, 1);
            }

            return RedirectToAction("Cart", new {returnUrl});

        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ID == productId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }

            return RedirectToAction("Cart", new { returnUrl });
        }

        public PartialViewResult _summary(Cart cart)
        {
            return PartialView(cart);
        }
    }
}