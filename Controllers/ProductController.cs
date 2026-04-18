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

    public IActionResult Products(string? category, string? search, string sort = "featured", int page = 1)
    {
        var query = _db.Products.AsQueryable();

        if (!string.IsNullOrWhiteSpace(category))
        {
            query = query.Where(p => p.Category == category);
        }

        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(p => p.Name.Contains(search) || p.Description.Contains(search));
        }

        query = sort switch
        {
            "price-low" => query.OrderBy(p => p.Price),
            "price-high" => query.OrderByDescending(p => p.Price),
            "name" => query.OrderBy(p => p.Name),
            _ => query.OrderByDescending(p => p.Id)
        };

        var totalItems = query.Count();
        var totalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

        if (totalPages == 0)
        {
            totalPages = 1;
        }

        if (page < 1)
        {
            page = 1;
        }

        if (page > totalPages)
        {
            page = totalPages;
        }

        var products = query
            .Skip((page - 1) * PageSize)
            .Take(PageSize)
            .ToList();

        ViewBag.Categories = _db.Products
            .Select(p => p.Category)
            .Distinct()
            .OrderBy(c => c)
            .ToList();

        ViewBag.CurrentCategory = category;
        ViewBag.Search = search;
        ViewBag.Sort = sort;
        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = totalPages;
        ViewBag.TotalItems = totalItems;

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
