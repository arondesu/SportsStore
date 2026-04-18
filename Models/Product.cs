using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Category { get; set; } = string.Empty;

    [Range(0.01, 1_000_000)]
    public decimal Price { get; set; }

    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    [Display(Name = "Image URL")]
    public string ImageUrl { get; set; } = string.Empty;

    [Range(0, 10000)]
    [Display(Name = "Stock Quantity")]
    public int StockQuantity { get; set; }
}
