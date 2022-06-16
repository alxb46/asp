using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaShop.Models;

namespace PizzaShop.Configurations
{
	public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
	{
        public List<Ingredient> ingredients = new List<Ingredient>();

        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            ingredients.Add(new Ingredient { Id = 1, Name = "Cream sauce", Price = 13.0m, Image = "Pictures/Ingredients/Cream-sauce.png" });
            ingredients.Add(new Ingredient { Id = 2, Name = "Paprika", Price = 13.0m, Image = "Pictures/Ingredients/Paprika.png" });
            ingredients.Add(new Ingredient { Id = 3, Name = "Oregano", Price = 13.0m, Image = "Pictures/Ingredients/Oregano.png" });
            ingredients.Add(new Ingredient { Id = 4, Name = "Parmesan cheese", Price = 13.0m, Image = "Pictures/Ingredients/Parmesan-cheese.png" });
            ingredients.Add(new Ingredient { Id = 5, Name = "Dor Blue cheese", Price = 13.0m, Image = "Pictures/Ingredients/Dor-Blue_cheese.png" });
            ingredients.Add(new Ingredient { Id = 6, Name = "Hard cheese", Price = 13.0m, Image = "Pictures/Ingredients/Hard-cheese.png" });
            ingredients.Add(new Ingredient { Id = 7, Name = "Mozzarella", Price = 13.0m, Image = "Pictures/Ingredients/Mozzarella.png" });
            ingredients.Add(new Ingredient { Id = 8, Name = "Hunting sausages", Price = 13.0m, Image = "Pictures/Ingredients/Hunting-sausages.png" });
            ingredients.Add(new Ingredient { Id = 9, Name = "Tomatoes", Price = 13.0m, Image = "Pictures/Ingredients/Tomatoes.png" });
            ingredients.Add(new Ingredient { Id = 10, Name = "Tomato sauce", Price = 13.0m, Image = "Pictures/Ingredients/Tomato-sauce.png" });
            ingredients.Add(new Ingredient { Id = 11, Name = "live oil", Price = 13.0m, Image = "Pictures/Ingredients/live-oil.png" });
            ingredients.Add(new Ingredient { Id = 12, Name = "Baked chicken", Price = 13.0m, Image = "Pictures/Ingredients/Baked-chicken.png" });
            ingredients.Add(new Ingredient { Id = 13, Name = "Roasted mushrooms", Price = 13.0m, Image = "Pictures/Ingredients/Roasted-mushrooms.png" });
            ingredients.Add(new Ingredient { Id = 14, Name = "Red onion", Price = 13.0m, Image = "Pictures/Ingredients/Red-onion.png" });
            ingredients.Add(new Ingredient { Id = 15, Name = "Smoked chicken", Price = 13.0m, Image = "Pictures/Ingredients/Smoked-chicken.png" });
            ingredients.Add(new Ingredient { Id = 16, Name = "Pineapple", Price = 13.0m, Image = "Pictures/Ingredients/Pineapple.png" });

            _ = builder.HasData(
                ingredients
                );

        }
    }
}

