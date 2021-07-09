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
                    new Ingredient { Name = "Cream sauce"},
                    new Ingredient { Name = "Paprika"},
                    new Ingredient { Name = "Oregano"},
                    new Ingredient { Name = "Parmesan cheese"},
                    new Ingredient { Name = "Dor Blue cheese"},
                    new Ingredient { Name = "Hard cheese"},
                    new Ingredient { Name = "Mozzarella"},
                    new Ingredient { Name = "Hunting sausages"},
                    new Ingredient { Name = "Tomatoes"},
                    new Ingredient { Name = "Tomato sauce"},
                    new Ingredient { Name = "Olive oil" },
                    new Ingredient { Name = "Green onions" },
                    new Ingredient { Name = "Baked chicken" },
                    new Ingredient { Name = "Roasted mushrooms" },
                    new Ingredient { Name = "Red onion" },
                    new Ingredient { Name = "Smoked chicken" },
                    new Ingredient { Name = "Pineapple" }
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
                _ = context.Pizzas.AddRangeAsync(
                   new Pizza
                   {
                       Name = "Jack Daniels",
                       Image = "https://storage.smilefood.ua/storage/b8/db/b8db8fd85160a980657945d7526bad00.jpg",
                       Price = 8,
                       Description = "Spicy pizza based on Jack Daniels sauce," +
                       " with Mozzarella cheese, baked chicken," +
                       " hunting sausages, fried mushrooms, sweet red onions," +
                       " ripe tomatoes, garnished with green onions."
                   }
               );

                _ = context.Pizzas.AddRangeAsync(
                   new Pizza
                   {
                       Name = "Hawaiian",
                       Image = "https://storage.smilefood.ua/storage/48/aa/48aaf10a1f480ede39afcd9753eb7fa5.jpg",
                       Price = 6,
                       Description = "Pizza with smoked chicken fillet, pineapple," +
                       " oregano, Mozzarella cheese, creamy garlic sauce"
                   }
               );
                _ = context.SaveChanges();
            }
        }

        public static void InitializePizzaIngredients(PizzaContext context)
        {

            if (!context.PizzaIngredients.Any())
            {
                var pizzas = context.Pizzas.ToList();
                var ingredients = context.Ingredients.ToList();

                _ = context.PizzaIngredients.AddRangeAsync(
                    
                    new PizzaIngredient
                    { PizzaId = 1, IngredientId =1},
                    new PizzaIngredient
                    { PizzaId = 1, IngredientId = 2 },
                    new PizzaIngredient
                    { PizzaId = 1, IngredientId = 3 },
                    new PizzaIngredient
                    { PizzaId = 1, IngredientId = 4 },
                    new PizzaIngredient
                    { PizzaId = 1, IngredientId = 5 },
                    new PizzaIngredient
                    { PizzaId = 1, IngredientId = 6 },
                    new PizzaIngredient
                    { PizzaId = 1, IngredientId = 7 },
                    new PizzaIngredient
                    { PizzaId = 2, IngredientId = 8 },
                    new PizzaIngredient
                    { PizzaId = 2, IngredientId = 9 },
                    new PizzaIngredient
                    { PizzaId = 2, IngredientId = 10 },
                    new PizzaIngredient
                    { PizzaId = 2, IngredientId = 3 },
                    new PizzaIngredient
                    { PizzaId = 2, IngredientId = 11 },
                    new PizzaIngredient
                    { PizzaId = 2, IngredientId = 12 },
                    new PizzaIngredient
                    { PizzaId = 2, IngredientId = 7 },
                    new PizzaIngredient
                    { PizzaId = 2, IngredientId = 13 },
                    new PizzaIngredient
                    { PizzaId = 2, IngredientId = 14 },
                    new PizzaIngredient
                    { PizzaId = 2, IngredientId = 15 },
                    new PizzaIngredient
                    { PizzaId = 3, IngredientId = 16 },
                    new PizzaIngredient
                    { PizzaId = 3, IngredientId = 17 },
                    new PizzaIngredient
                    { PizzaId = 3, IngredientId = 1 },
                    new PizzaIngredient
                    { PizzaId = 3, IngredientId = 3 },
                    new PizzaIngredient
                    { PizzaId = 3, IngredientId = 11 },
                    new PizzaIngredient
                    { PizzaId = 3, IngredientId = 7 }

                );
                _ = context.SaveChanges();
            }
        }

        public static void Initialize(PizzaContext context)
        {
            //if (!context.Pizzas.Any())
            //{
            //    var pizzasList = context.Pizzas.ToList();
            //    var pizzasIngredientList = context.PizzaIngredients.ToList();
            //    var ingredientsList = context.Ingredients.ToList();

            //    for (int i = 0; i < pizzasIngredientList.Count; i++)
            //    {
            //        int pizzaId = pizzasIngredientList[i].PizzaId;
            //        int ingredientId = pizzasIngredientList[i].IngredientId;

            //        pizzasList.ElementAt(pizzaId).PizzaIngredients.Add(pizzasIngredientList[i]);
            //        ingredientsList.ElementAt(ingredientId).PizzaIngredients.Add(pizzasIngredientList[i]);
            //    }
            //}
        }
    }
}
