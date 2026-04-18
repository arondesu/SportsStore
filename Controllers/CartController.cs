using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers;

public class CartController : Controller
{
    private readonly AppDbContext _db;
    private const string CartSessionKey = "Cart";

    public CartController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Cart()
    {
        var cart = GetCartItems();
        return View(cart);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddToCart(int productId, string? returnUrl)
    {
        var product = _db.Products.FirstOrDefault(p => p.Id == productId);
        if (product == null)
        {
            return NotFound();
        }

        var cart = GetCartItems();
        var existingItem = cart.FirstOrDefault(c => c.ProductId == productId);

        if (existingItem == null)
        {
            cart.Add(new CartItem
            {
                ProductId = product.Id,
                ProductName = product.Name,
                Price = product.Price,
                Quantity = 1,
                ImageUrl = product.ImageUrl
            });
        }
        else
        {
            existingItem.Quantity += 1;
        }

        SaveCartItems(cart);

        if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
        {
            return LocalRedirect(returnUrl);
        }

        return RedirectToAction("Products", "Product");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult RemoveFromCart(int productId)
    {
        var cart = GetCartItems();
        var item = cart.FirstOrDefault(c => c.ProductId == productId);

        if (item != null)
        {
            cart.Remove(item);
            SaveCartItems(cart);
        }

        return RedirectToAction(nameof(Cart));
    }

    private List<CartItem> GetCartItems()
    {
        return HttpContext.Session.GetObject<List<CartItem>>(CartSessionKey) ?? new List<CartItem>();
    }

    private void SaveCartItems(List<CartItem> cart)
    {
        HttpContext.Session.SetObject(CartSessionKey, cart);
    }
}
