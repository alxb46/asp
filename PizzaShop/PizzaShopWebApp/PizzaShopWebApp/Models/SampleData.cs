using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShopWebApp.Models
{
    public class SampleData
    {
        public static void InitializeIngredients(PizzaContext context)
        {
            if (!context.Ingredients.Any())
            {
                _ = context.Ingredients.AddRangeAsync(
                    new Ingredient
                    {
                        Name = "Cream sauce"
                    },
                    new Ingredient
                    {
                        Name = "Paprika"
                    },
                    new Ingredient
                    {
                        Name = "Oregano"
                    },
                    new Ingredient
                    {
                        Name = "Parmesan cheese"
                    },
                    new Ingredient
                    {
                        Name = "Dor Blue cheese"
                    },
                    new Ingredient
                    {
                        Name = "Hard cheese"
                    },
                    new Ingredient
                    {
                        Name = "Mozzarella"
                    }

                );
                _ = context.SaveChanges();
            }
        }

        public static void InitializePizzas(PizzaContext context)
        {
            if (!context.Pizzas.Any())
            {
                _ = context.Pizzas.AddRangeAsync(
                    new Pizza
                    {
                        Name = "4 cheese",
                        Image = "https://storage.smilefood.ua/storage/17/51/175169e45ed67c4c8b723f1b009b4b0d.jpg",
                        Price = 7,
                        Description = "Pizza with Parmesan cheese, " +
                        "Dor blue, Mozzarella, Hollandaise, paprika, " +
                        "oregano and creamy sauce"
                    }
                );
                _ = context.SaveChanges();
            }
        }

        public static void InitializePizzaIngredients(PizzaContext context)
        {
            if (!context.PizzaIngredients.Any())
            {
                _ = context.PizzaIngredients.AddRangeAsync(
                    
                    new PizzaIngredient
                    {
                        PizzaId = 1,
                        IngredientId =1
                    },
                    new PizzaIngredient
                    {
                        PizzaId = 1,
                        IngredientId = 2
                    },
                    new PizzaIngredient
                    {
                        PizzaId = 1,
                        IngredientId = 3
                    },
                    new PizzaIngredient
                    {
                        PizzaId = 1,
                        IngredientId = 4
                    },
                    new PizzaIngredient
                    {
                        PizzaId = 1,
                        IngredientId = 5
                    },
                    new PizzaIngredient
                    {
                        PizzaId = 1,
                        IngredientId = 6
                    },
                    new PizzaIngredient
                    {
                        PizzaId = 1,
                        IngredientId = 7
                    }

                );
                _ = context.SaveChanges();
            }
        }
    }
}
