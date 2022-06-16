using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaShop.Models;

namespace PizzaShop.Configurations
{
	public class PizzaIngredientConfiguration : IEntityTypeConfiguration<PizzaIngredient>
	{
        public void Configure(EntityTypeBuilder<PizzaIngredient> builder)
        {
           builder.HasData(
               //first pizza ingredients
                new PizzaIngredient() { PizzaId = 1, IngredientId = 1},
                new PizzaIngredient() { PizzaId = 1, IngredientId = 2 },
                new PizzaIngredient() { PizzaId = 1, IngredientId = 3 },
                new PizzaIngredient() { PizzaId = 1, IngredientId = 4 },
                new PizzaIngredient() { PizzaId = 1, IngredientId = 5 },
                new PizzaIngredient() { PizzaId = 1, IngredientId = 6 },
                new PizzaIngredient() { PizzaId = 1, IngredientId = 7 },
                //twice pizza ingredients
                
                new PizzaIngredient() { PizzaId = 2, IngredientId = 8 },
                new PizzaIngredient() { PizzaId = 2, IngredientId = 9 },
                new PizzaIngredient() { PizzaId = 2, IngredientId = 10 },
                new PizzaIngredient() { PizzaId = 2, IngredientId = 11 },
                new PizzaIngredient() { PizzaId = 2, IngredientId = 12 },
                new PizzaIngredient() { PizzaId = 2, IngredientId = 13 },
                new PizzaIngredient() { PizzaId = 2, IngredientId = 14 },
                //third pizza ingredients
                new PizzaIngredient() { PizzaId = 3, IngredientId = 15 },
                new PizzaIngredient() { PizzaId = 3, IngredientId = 16 },
                new PizzaIngredient() { PizzaId = 3, IngredientId = 1 },
                new PizzaIngredient() { PizzaId = 3, IngredientId = 3 },
                new PizzaIngredient() { PizzaId = 3, IngredientId = 11 },
                new PizzaIngredient() { PizzaId = 3, IngredientId = 7 }
            );

           // builder.HasData(
           //    //first pizza ingredients
           //    new PizzaIngredient() { Id = 1, PizzaId = 1, IngredientId = 1 },
           //    new PizzaIngredient() { Id = 2, PizzaId = 1, IngredientId = 2 },
           //    new PizzaIngredient() { Id = 3, PizzaId = 1, IngredientId = 3 },
           //    new PizzaIngredient() { Id = 4, PizzaId = 1, IngredientId = 4 },
           //    new PizzaIngredient() { Id = 5, PizzaId = 1, IngredientId = 5 },
           //    new PizzaIngredient() { Id = 6, PizzaId = 1, IngredientId = 6 },
           //    new PizzaIngredient() { Id = 7, PizzaId = 1, IngredientId = 7 }


           //);
        }
    }
}

