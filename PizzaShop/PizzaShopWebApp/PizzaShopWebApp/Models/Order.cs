using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShopWebApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
    }
}
