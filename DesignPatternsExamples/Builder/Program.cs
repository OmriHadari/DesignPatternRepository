using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buider design pattern demo");

            Director director = new Director();
            IBuilder carBuilder = new Car("Ford");
            IBuilder motorcycleBuilder = new Motorcycle("Yamaha");

            // Constructing a car
            director.Construct(carBuilder);
            Product car = carBuilder.GetVehicle();
            car.Show();
            Console.WriteLine();

            // Constructing a bike
            director.Construct(motorcycleBuilder);
            Product bike = motorcycleBuilder.GetVehicle();
            bike.Show();

            Console.ReadLine();
        }
    }
}
