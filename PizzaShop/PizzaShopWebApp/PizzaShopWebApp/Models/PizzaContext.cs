using Microsoft.EntityFrameworkCore;

namespace PizzaShopWebApp.Models
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredients { get; set; }

        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<PizzaIngredient>().HasKey(sc => new { sc.PizzaId, sc.IngredientId });

            _ = modelBuilder.Entity<PizzaIngredient>()
                .HasOne(sc => sc.Pizza)
                .WithMany(s => s.PizzaIngredients)
                .HasForeignKey(sc => sc.PizzaId);

            _ = modelBuilder.Entity<PizzaIngredient>()
                .HasOne(sc => sc.Ingredient)
                .WithMany(s => s.PizzaIngredients)
                .HasForeignKey(sc => sc.IngredientId);
        }
    }
}
