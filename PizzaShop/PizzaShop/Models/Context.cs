using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Configurations;

namespace PizzaShop.Models
{
	public class Context : DbContext
	{
		public DbSet<Pizza> Pizzas { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;

		public Context(DbContextOptions<Context> options) : base(options)
        {
            ConnectToDatabase();
        }

        private void ConnectToDatabase()
        {
            // if database already exists then delete it
            //if (Database.CanConnect())
            //{
            Database.EnsureDeleted();
            //}

            //// create database
            _ = Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.LogTo(s => Debug.WriteLine(s));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            _ = modelBuilder
            .Entity<Ingredient>()
            .HasMany(c => c.Pizzas)
            .WithMany(s => s.Ingredients)
            .UsingEntity<PizzaIngredient>(
                j => j
                    .HasOne(pt => pt.Pizza)
                    .WithMany(t => t.PizzaIngredients)
                    .HasForeignKey(pt => pt.PizzaId),
                j => j
                    .HasOne(pt => pt.Ingredient)
                    .WithMany(p => p.PizzaIngredients)
                    .HasForeignKey(pt => pt.IngredientId),
                j =>
                {
                    j.HasKey(t => new { t.PizzaId, t.IngredientId });
                    _ = j.ToTable("PizzaIngredient");
                });


            _ = modelBuilder.ApplyConfiguration(new IngredientConfiguration());
            _ = modelBuilder.ApplyConfiguration(new PizzaConfiguration());
            _ = modelBuilder.ApplyConfiguration(new PizzaIngredientConfiguration());

        }
    }
}

