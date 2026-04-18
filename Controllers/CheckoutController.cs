using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers;

public class CheckoutController : Controller
{
    private const string CartSessionKey = "Cart";

    [HttpGet]
    public IActionResult Checkout()
    {
        return View(new CheckoutViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Checkout(CheckoutViewModel model)
    {
        var cart = HttpContext.Session.GetObject<List<CartItem>>(CartSessionKey) ?? new List<CartItem>();

        if (!cart.Any())
        {
            ModelState.AddModelError(string.Empty, "Your cart is empty. Please add products before checkout.");
        }

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var orderTotal = cart.Sum(c => c.LineTotal);

        HttpContext.Session.SetObject(CartSessionKey, new List<CartItem>());

        ViewBag.OrderTotal = orderTotal;
        return View("CheckoutSuccess", model);
    }
}
