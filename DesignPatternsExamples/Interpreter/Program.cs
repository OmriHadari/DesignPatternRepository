using System;
using System.Text.RegularExpressions;

namespace Interpreter
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Language
            var domainLanguage = "order x10 '2L water bottles' from Tesco";
            Order interpretedOrder = Order.Parse(domainLanguage);

            Console.WriteLine(string.Format("QtyToBuy: {0}", interpretedOrder.Qty.ToString()));
            Console.WriteLine(string.Format("ProductToBuy: {0}", interpretedOrder.Product));
            Console.WriteLine(string.Format("ToBuyFrom: {0}", interpretedOrder.Source));

            Console.ReadLine();
        }

        // Grammer Representation
        const string optionalSpace = " ?";
        const string qty = "x(?<qty>\\d+)" + optionalSpace;
        const string product = "'(?<product>[\\w ]+)'" + optionalSpace;
        const string source = "from (?<source>\\w+)";
        const string orderCommand = "order " + optionalSpace + qty + product + source;

        public class Order
        {
            public static Regex _regex = new Regex(orderCommand);

            public Order(int qty, string product, string source)
            {
                Qty = qty;
                Product = product;
                Source = source;
            }

            public int Qty { get; }
            public string Product { get; }
            public string Source { get; }

            // Interperter
            public static Order Parse(string command)
            {
                var match = _regex.Match(command);

                if (!match.Success)
                    return null;

                var qty = int.Parse(match.Groups["qty"].Value);
                var product = match.Groups["product"].Value;
                var source = match.Groups["source"].Value;

                return new Order(qty, product, source);
            }
        }
    }
}
