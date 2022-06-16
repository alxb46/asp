using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaShop.Models;

namespace PizzaShop.Configurations
{
    public class PizzaConfiguration : IEntityTypeConfiguration<Pizza>
    {
        public void Configure(EntityTypeBuilder<Pizza> builder)
        {
            _ = builder.HasData(
                    new Pizza
                    {
                        Id = 1,
                        Name = "4 Cheese",
                        Image = "Pictures/Pizzas/cheese_4.jpg",
                        Price = 134.0m,
                        Description = "Pizza with Parmesan cheese, " +
                          "Dor blue, Mozzarella, Hollandaise, paprika, " +
                          "oregano and creamy sauce",
                    },
                    
                    new Pizza
                    {
                        Id = 2,
                        Name = "Jack Daniels",
                        Image = "Pictures/Pizzas/jack_daniels.jpg",
                        Price = 156.0m,
                        Description = "Spicy pizza based on Jack Daniels sauce," +
                       " with Mozzarella cheese, baked chicken," +
                       " hunting sausages, fried mushrooms, sweet red onions," +
                       " ripe tomatoes, garnished with green onions."
                    },
                    new Pizza
                    {
                        Id = 3,
                        Name = "Hawaiian",
                        Image = "Pictures/Pizzas/hawaiian.jpg",
                        Price = 116.0m,
                        Description = "Pizza with smoked chicken fillet, pineapple," +
                       " oregano, Mozzarella cheese, creamy garlic sauce"
                    }

                );
           
        }
    }
}

