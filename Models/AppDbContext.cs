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
            new Product { Id = 1, Name = "Air Sprint Running Shoes", Category = "Shoes", Price = 3799, Description = "Featherlight road-running shoes with breathable mesh, responsive foam, and durable outsole grip for daily mileage.", ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?auto=format&fit=crop&w=900&q=80", StockQuantity = 28 },
            new Product { Id = 2, Name = "Court Pro Basketball Shoes", Category = "Shoes", Price = 4499, Description = "High-cut basketball shoes with ankle lockdown, multi-court traction pattern, and impact-absorbing heel cushioning.", ImageUrl = "https://images.unsplash.com/photo-1511556532299-8f662fc26c06?auto=format&fit=crop&w=900&q=80", StockQuantity = 21 },
            new Product { Id = 3, Name = "Metro FC Home Jersey", Category = "Jerseys", Price = 2299, Description = "Official-inspired football jersey using moisture-wicking fabric and breathable side panels for hot-weather play.", ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?auto=format&fit=crop&w=900&q=80", StockQuantity = 46 },
            new Product { Id = 4, Name = "Tigers Basketball Jersey", Category = "Jerseys", Price = 2599, Description = "Game-ready basketball jersey with lightweight knit texture, quick-dry comfort, and all-day relaxed fit.", ImageUrl = "https://images.unsplash.com/photo-1503341455253-b2e723bb3dbb?auto=format&fit=crop&w=900&q=80", StockQuantity = 34 },
            new Product { Id = 5, Name = "Match Football", Category = "Equipment", Price = 1399, Description = "FIFA-size style 5 football with machine-stitched panels, stable flight, and reinforced bladder for longer use.", ImageUrl = "https://images.unsplash.com/photo-1614632537423-1e6c2e7e0aab?auto=format&fit=crop&w=900&q=80", StockQuantity = 55 },
            new Product { Id = 6, Name = "Performance Basketball", Category = "Equipment", Price = 1599, Description = "All-surface basketball featuring deep channel grip, balanced bounce, and premium composite cover.", ImageUrl = "https://images.unsplash.com/photo-1519861531473-9200262188bf?auto=format&fit=crop&w=900&q=80", StockQuantity = 48 },
            new Product { Id = 7, Name = "Training Cones Set", Category = "Equipment", Price = 949, Description = "Set of 20 flexible training cones with carry rack for speed drills, footwork stations, and team practice sessions.", ImageUrl = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55?auto=format&fit=crop&w=900&q=80", StockQuantity = 62 },
            new Product { Id = 8, Name = "Sports Duffel Bag", Category = "Accessories", Price = 1999, Description = "Large-capacity duffel with ventilated shoe compartment, padded shoulder strap, and water-resistant base panel.", ImageUrl = "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?auto=format&fit=crop&w=900&q=80", StockQuantity = 31 },
            new Product { Id = 9, Name = "Insulated Water Bottle", Category = "Accessories", Price = 749, Description = "Double-wall insulated bottle that keeps drinks cool for training sessions, commutes, and weekend games.", ImageUrl = "https://images.unsplash.com/photo-1523362628745-0c100150b504?auto=format&fit=crop&w=900&q=80", StockQuantity = 84 },
            new Product { Id = 10, Name = "Wrist Sweatbands", Category = "Accessories", Price = 449, Description = "Pair of stretch-fit wrist sweatbands with soft absorbent cotton blend for court, gym, and running workouts.", ImageUrl = "https://images.unsplash.com/photo-1517836357463-d25dfeac3438?auto=format&fit=crop&w=900&q=80", StockQuantity = 95 },
            new Product { Id = 11, Name = "GripFit Goalkeeper Gloves", Category = "Accessories", Price = 1299, Description = "Goalkeeper gloves with latex palm grip, finger support zones, and secure wrist wrap for confident saves.", ImageUrl = "https://images.unsplash.com/photo-1546519638-68e109498ffc?auto=format&fit=crop&w=900&q=80", StockQuantity = 37 },
            new Product { Id = 12, Name = "Power Jump Rope", Category = "Equipment", Price = 599, Description = "Adjustable speed rope with anti-slip handles and smooth bearings for HIIT, cardio intervals, and endurance sessions.", ImageUrl = "https://images.unsplash.com/photo-1599059813005-11265ba4b4ce?auto=format&fit=crop&w=900&q=80", StockQuantity = 76 },
            new Product { Id = 13, Name = "Velocity Indoor Futsal Shoes", Category = "Shoes", Price = 3399, Description = "Indoor futsal shoes with non-marking outsole, close-touch upper, and quick-cut support for fast small-sided games.", ImageUrl = "https://images.unsplash.com/photo-1551107696-a4b0c5a0d9a2?auto=format&fit=crop&w=900&q=80", StockQuantity = 24 },
            new Product { Id = 14, Name = "Elite Training Jersey", Category = "Jerseys", Price = 2099, Description = "Quick-dry training jersey with airflow mesh zones and lightweight stretch fit for gym circuits and team drills.", ImageUrl = "https://images.unsplash.com/photo-1562771242-a02d9090c90c?auto=format&fit=crop&w=900&q=80", StockQuantity = 49 },
            new Product { Id = 15, Name = "All-Court Knee Pads", Category = "Accessories", Price = 849, Description = "Shock-absorbing knee pads with ergonomic contour and breathable knit for volleyball and basketball protection.", ImageUrl = "https://images.unsplash.com/photo-1597074866923-dc0589150358?auto=format&fit=crop&w=900&q=80", StockQuantity = 61 },
            new Product { Id = 16, Name = "Agility Speed Ladder", Category = "Equipment", Price = 1149, Description = "Durable 6-meter speed ladder with adjustable rungs for footwork, acceleration, and conditioning routines.", ImageUrl = "https://images.unsplash.com/photo-1517963628607-235ccdd5476b?auto=format&fit=crop&w=900&q=80", StockQuantity = 41 },
            new Product { Id = 17, Name = "Stadium Cap", Category = "Accessories", Price = 699, Description = "Curved-brim sports cap with sweatband lining, ventilated eyelets, and adjustable back strap for daily wear.", ImageUrl = "https://images.unsplash.com/photo-1588850561407-ed78c282e89b?auto=format&fit=crop&w=900&q=80", StockQuantity = 68 },
            new Product { Id = 18, Name = "PowerLift Training Shoes", Category = "Shoes", Price = 4099, Description = "Stable low-drop training shoes with reinforced heel clip and grippy outsole for lifting and strength sessions.", ImageUrl = "https://images.unsplash.com/photo-1600185365926-3a2ce3cdb9eb?auto=format&fit=crop&w=900&q=80", StockQuantity = 23 }
        );
    }
}
