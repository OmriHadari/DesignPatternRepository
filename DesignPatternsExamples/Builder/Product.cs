using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Product
    {
        private List<string> parts;

        public Product()
        {
            parts = new List<string>();
        }

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Parts of product: ");

            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
