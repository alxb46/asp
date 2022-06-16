using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaShop.Models
{
	public class Pizza
	{
		[Column("Id")]
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string? Image { get; set; }
		public string? Name { get; set; }
		public decimal Price { get; set; }
		public string? Description { get; set; }

		public virtual List<Ingredient> Ingredients { get; set; } = new();

		public virtual List<PizzaIngredient> PizzaIngredients { get; set; } = new();
	}
}

