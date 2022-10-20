using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public IEnumerable<CartItem> ShoppingCart { get; set; }
    }
}
