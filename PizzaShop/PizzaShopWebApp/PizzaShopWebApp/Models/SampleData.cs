using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShopWebApp.Models
{
    public class SampleData
    {
        public static void Initialize(PizzaContext context)
        {
            if (!context.Ingredients.Any() && !context.Pizzas.Any())
            {

                #region init ingredients
                Ingredient cream_sauce = new Ingredient { Name = "Cream sauce" };
                Ingredient paprika = new Ingredient { Name = "Paprika" };
                Ingredient oregano = new Ingredient { Name = "Oregano" };
                Ingredient parmesan_cheese = new Ingredient { Name = "Parmesan cheese" };
                Ingredient dor_blue_cheese = new Ingredient { Name = "Dor Blue cheese" };
                Ingredient hard_cheese = new Ingredient { Name = "Hard cheese" };
                Ingredient mozzarella = new Ingredient { Name = "Mozzarella" };
                Ingredient hunting_sausages = new Ingredient { Name = "Hunting sausages" };
                Ingredient tomatoes = new Ingredient { Name = "Tomatoes" };
                Ingredient tomato_sauce = new Ingredient { Name = "Tomato sauce" };
                Ingredient olive_oil = new Ingredient { Name = "Olive oil" };
                Ingredient green_onions = new Ingredient { Name = "Green onions" };
                Ingredient baked_chicken = new Ingredient { Name = "Baked chicken" };
                Ingredient roasted_mushrooms = new Ingredient { Name = "Roasted mushrooms" };
                Ingredient red_onion = new Ingredient { Name = "Red onion" };
                Ingredient smoked_chicken = new Ingredient { Name = "Smoked chicken" };
                Ingredient pineapple = new Ingredient { Name = "Pineapple" };
                #endregion

                #region add context ingredients
                _ = context.Ingredients.AddRangeAsync(
                    cream_sauce,
                    paprika,
                    oregano,
                    parmesan_cheese,
                    dor_blue_cheese, //5
                    hard_cheese,
                    mozzarella,
                    hunting_sausages,
                    tomatoes,
                    tomato_sauce, //10
                    olive_oil,
                    green_onions,
                    baked_chicken,
                    roasted_mushrooms,
                    red_onion, //15
                    smoked_chicken,
                    pineapple);

                #endregion

                List<Ingredient> ingredients_collection = new List<Ingredient>() { cream_sauce, paprika, oregano, parmesan_cheese, dor_blue_cheese, hard_cheese, mozzarella };
               // four_chesse.Ingredients.AddRange(ingredients_collection);


                Pizza four_chesse = new Pizza
                {
                    Name = "4 cheese",
                    Image = "https://storage.smilefood.ua/storage/17/51/175169e45ed67c4c8b723f1b009b4b0d.jpg",
                    Price = 7,
                    Description = "Pizza with Parmesan cheese, " +
                          "Dor blue, Mozzarella, Hollandaise, paprika, " +
                          "oregano and creamy sauce",
                    Ingredients = ingredients_collection
                };
                Pizza jack_daniels = new Pizza
                {
                    Name = "Jack Daniels",
                    Image = "https://storage.smilefood.ua/storage/b8/db/b8db8fd85160a980657945d7526bad00.jpg",
                    Price = 8,
                    Description = "Spicy pizza based on Jack Daniels sauce," +
                       " with Mozzarella cheese, baked chicken," +
                       " hunting sausages, fried mushrooms, sweet red onions," +
                       " ripe tomatoes, garnished with green onions."
                };
                Pizza hawaiian = new Pizza
                {
                    Name = "Hawaiian",
                    Image = "https://storage.smilefood.ua/storage/48/aa/48aaf10a1f480ede39afcd9753eb7fa5.jpg",
                    Price = 6,
                    Description = "Pizza with smoked chicken fillet, pineapple," +
                       " oregano, Mozzarella cheese, creamy garlic sauce"
                };

               
              
                ingredients_collection = new List<Ingredient>() { hunting_sausages, tomatoes, tomato_sauce, oregano, olive_oil,
                green_onions, mozzarella, baked_chicken, roasted_mushrooms, red_onion };
                jack_daniels.Ingredients.AddRange(ingredients_collection);


                ingredients_collection = new List<Ingredient>() { smoked_chicken, pineapple, cream_sauce, oregano, olive_oil, mozzarella };
                hawaiian.Ingredients.AddRange(ingredients_collection);

                _ = context.Pizzas.AddRangeAsync(
                   four_chesse, jack_daniels, hawaiian
              );

                List<Pizza> pizzas = context.Pizzas.ToList();
                List<Pizza> pizzas2 = pizzas;

                _ = context.SaveChanges();
            }
        }

    }

    /*public static void InitializePizzas(PizzaContext context)
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
    }*/

    //public static void InitializePizzaIngredients(PizzaContext context)
    //{

    //    if (!context.PizzaIngredients.Any())
    //    {
    //        var pizzas = context.Pizzas.ToList();
    //        var ingredients = context.Ingredients.ToList();

    //        _ = context.PizzaIngredients.AddRangeAsync(

    //            new PizzaIngredient
    //            { PizzaId = 3, IngredientId = 11 },
    //            new PizzaIngredient
    //            { PizzaId = 3, IngredientId = 7 }

    //        );
    //        _ = context.SaveChanges();
    //    }
    //}

    //public static void Initialize(PizzaContext context)
    //{

    //}

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

