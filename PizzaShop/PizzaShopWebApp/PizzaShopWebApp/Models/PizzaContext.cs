using Microsoft.EntityFrameworkCore;

namespace PizzaShopWebApp.Models
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        public PizzaContext(DbContextOptions<PizzaContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
