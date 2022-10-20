using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Interfaces
{
    public interface ICart
    {
        Product GetProductDetails(int itemId);
        bool CheckItemAvailability(Product product);
        bool LockItemInStock(int itemId, int quantity);
        int AddItemToCart(int itemId, int quantity);
        double GetCartPrice(int cartId);
    }
}
