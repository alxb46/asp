using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaShop.Models
{
	public class PizzaIngredient
	{

		public int PizzaId { get; set; }
		public Pizza? Pizza { get; set; }

		public int IngredientId { get; set; }
		public Ingredient? Ingredient { get; set; }
	}
}

