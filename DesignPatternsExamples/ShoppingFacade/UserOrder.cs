//using ShoppingCart.Implementations;
//using ShoppingCart.Interfaces;
//using ShoppingCart.Models;
//using System;
//
//namespace ShoppingFacade
//{
//    public class UserOrder : IUserOrder
//    {
//        public int AddToCart(int itemId, int qty)
//        {
//            Console.WriteLine("Start AddToCart");
//            ICart userCart = new ShoppingCartDetails();
//            int cartId = 0;
//            // Get item
//            Product product = userCart.GetProductDetails(itemId);
//            // Check availability
//            if (userCart.CheckItemAvailability(product))
//            {
//                // Lock item in stock
//                userCart.LockItemInStock(itemId, qty);
//                // Add Item to cart
//                cartId = userCart.AddItemToCart(itemId, qty);
//            }
//
//            Console.WriteLine("End AddToCart");
//            return cartId;
//        }
//
//        public int PlaceOrder(int cartId, int userId)
//        {
//            Console.WriteLine("Start PlaceOrderDetails");
//            int orderId = -1;
//            IWallet wallet = new Wallet();
//            ITax tax = new Tax();
//            ICart userCart = new ShoppingCartDetails();
//            IAddress address = new AddressDetails();
//            IOrder order = new Order();
//            // Get tax by state
//            double stateTax = tax.GetTaxByState("California");
//            // Apply tax on cart items
//            tax.ApplyTax(cartId, stateTax);
//            // Get user wallet balance
//            double userWalletBalance = wallet.GetUserBalance(userId);
//            // Get cart item price
//            double cartPrice = userCart.GetCartPrice(cartId);
//            // Compare balance and price
//            if (userWalletBalance >= cartPrice)
//            {
//                // Get user address
//                Address userAddress = address.GetAddressDetails(userId);
//                // Place Order
//                orderId = order.PlaceOrderDetails(cartId, userAddress.AddressId);
//            }
//            else
//                Console.WriteLine("Insufficient Funds");
//
//            Console.WriteLine("End PlaceOrderDetails");
//            return orderId;
//        }
//    }
//}
