using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers;

public class ProductController : Controller
{
    private readonly AppDbContext _db;
    private const int PageSize = 6;

    public ProductController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Products(string? category, int page = 1)
    {
        var query = _db.Products.AsQueryable();

        if (!string.IsNullOrWhiteSpace(category))
        {
            query = query.Where(p => p.Category == category);
        }

        var totalItems = query.Count();
        var totalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

        var products = query
            .OrderBy(p => p.Id)
            .Skip((page - 1) * PageSize)
            .Take(PageSize)
            .ToList();

        ViewBag.Categories = _db.Products
            .Select(p => p.Category)
            .Distinct()
            .OrderBy(c => c)
            .ToList();

        ViewBag.CurrentCategory = category;
        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = totalPages;

        return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = _db.Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }
}
