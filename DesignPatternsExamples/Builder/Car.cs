using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car : IBuilder
    {
        private string brandName;
        private Product product;

        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void StartupOperations()
        {
            product.Add(string.Format("Car brand: {0}", this.brandName));
        }

        public void BuildBody()
        {
            product.Add(string.Format("Fabricating car body"));
        }

        public void InsertWheels()
        {
            product.Add(string.Format("Added 4 wheels"));
        }

        public void AddHeadlights()
        {
            product.Add(string.Format("Added 2 headlights"));
        }

        public void EndOperations()
        {
            product.Add(string.Format("Construction Complete"));
        }

        public Product GetVehicle()
        {
            return product;
        }
    }
}
