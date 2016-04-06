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

        public ViewResult Cart(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(int productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ID == productId);

            if(product != null)
            {
                GetCart().AddItem(product, 1);
            }

            return RedirectToAction("Cart", new {returnUrl});

        }

        public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ID == productId);

            if (product != null)
            {
                GetCart().RemoveLine(product);
            }

            return RedirectToAction("Index", new { returnUrl });

        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if(cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }
    }
}