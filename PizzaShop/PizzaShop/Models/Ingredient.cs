using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaShop.Models
{
	public class Ingredient
	{
		[Column("Id")]
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string? Name { get; set; }
		public string? Image { get; set; }

		public decimal Price { get; set; }

		public virtual List<Pizza> Pizzas { get; set; } = new();

		public virtual List<PizzaIngredient> PizzaIngredients { get; set; } = new();

	}
}

