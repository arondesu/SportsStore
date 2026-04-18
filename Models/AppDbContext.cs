using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Air Sprint Running Shoes", Category = "Shoes", Price = 3599, Description = "Lightweight running shoes for daily training.", ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?auto=format&fit=crop&w=900&q=80", StockQuantity = 25 },
            new Product { Id = 2, Name = "Court Pro Basketball Shoes", Category = "Shoes", Price = 4299, Description = "High-grip shoes built for quick direction changes.", ImageUrl = "https://images.unsplash.com/photo-1511556532299-8f662fc26c06?auto=format&fit=crop&w=900&q=80", StockQuantity = 18 },
            new Product { Id = 3, Name = "Metro FC Home Jersey", Category = "Jerseys", Price = 2199, Description = "Breathable football jersey with moisture control.", ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?auto=format&fit=crop&w=900&q=80", StockQuantity = 40 },
            new Product { Id = 4, Name = "Tigers Basketball Jersey", Category = "Jerseys", Price = 2499, Description = "Comfort-fit basketball jersey for practice and games.", ImageUrl = "https://images.unsplash.com/photo-1503341455253-b2e723bb3dbb?auto=format&fit=crop&w=900&q=80", StockQuantity = 32 },
            new Product { Id = 5, Name = "Match Football", Category = "Equipment", Price = 1299, Description = "Durable size 5 football for school and club matches.", ImageUrl = "https://images.unsplash.com/photo-1614632537423-1e6c2e7e0aab?auto=format&fit=crop&w=900&q=80", StockQuantity = 50 },
            new Product { Id = 6, Name = "Performance Basketball", Category = "Equipment", Price = 1499, Description = "Indoor and outdoor basketball with textured grip.", ImageUrl = "https://images.unsplash.com/photo-1519861531473-9200262188bf?auto=format&fit=crop&w=900&q=80", StockQuantity = 45 },
            new Product { Id = 7, Name = "Training Cones Set", Category = "Equipment", Price = 899, Description = "Set of 20 cones for agility and speed drills.", ImageUrl = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55?auto=format&fit=crop&w=900&q=80", StockQuantity = 60 },
            new Product { Id = 8, Name = "Sports Duffel Bag", Category = "Accessories", Price = 1899, Description = "Spacious bag with shoe compartment.", ImageUrl = "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?auto=format&fit=crop&w=900&q=80", StockQuantity = 27 },
            new Product { Id = 9, Name = "Insulated Water Bottle", Category = "Accessories", Price = 699, Description = "Keeps drinks cool during long workouts.", ImageUrl = "https://images.unsplash.com/photo-1523362628745-0c100150b504?auto=format&fit=crop&w=900&q=80", StockQuantity = 80 },
            new Product { Id = 10, Name = "Wrist Sweatbands", Category = "Accessories", Price = 399, Description = "Soft and absorbent sweatbands for training.", ImageUrl = "https://images.unsplash.com/photo-1517836357463-d25dfeac3438?auto=format&fit=crop&w=900&q=80", StockQuantity = 90 },
            new Product { Id = 11, Name = "GripFit Goalkeeper Gloves", Category = "Accessories", Price = 1199, Description = "Goalkeeper gloves with padded palm and strong wrist support.", ImageUrl = "https://images.unsplash.com/photo-1546519638-68e109498ffc?auto=format&fit=crop&w=900&q=80", StockQuantity = 35 },
            new Product { Id = 12, Name = "Power Jump Rope", Category = "Equipment", Price = 549, Description = "Adjustable speed jump rope for cardio and endurance workouts.", ImageUrl = "https://images.unsplash.com/photo-1599059813005-11265ba4b4ce?auto=format&fit=crop&w=900&q=80", StockQuantity = 70 }
        );
    }
}
