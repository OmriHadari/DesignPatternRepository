using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TaxParcentage { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
    }
}
