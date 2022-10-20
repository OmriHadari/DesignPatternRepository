using System;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype demo\n");

            BasicCar nano_base = new Nano("Red Nano") { Price = 100000 };
            BasicCar ford_base = new Ford("Blue Ford") { Price = 200000 };
            BasicCar basicCar;

            // Nano
            basicCar = nano_base.Clone();
            basicCar.Price = nano_base.Price + BasicCar.SetPrice();
            Console.WriteLine(string.Format("Car is {0}, and its price is {1}", basicCar.ModelName, basicCar.Price));

            // Ford
            basicCar = ford_base.Clone();
            basicCar.Price = ford_base.Price + BasicCar.SetPrice();
            Console.WriteLine(string.Format("Car is {0}, and its price is {1}", basicCar.ModelName, basicCar.Price));

            Console.ReadLine();
        }
    }
}
