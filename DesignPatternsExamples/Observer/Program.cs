using Observer.Implementations;
using System;

namespace Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            NewsAgency agency1 = new NewsAgency("CNN");
            NewsAgency agency2 = new NewsAgency("BBC");
            NewsAgency agency3 = new NewsAgency("Al-Jazeera");
            weatherStation.Register(agency1);
            weatherStation.Register(agency2);
            weatherStation.Register(agency3);

            // Mocking temperature update.
            weatherStation.Temperature = 31.2f;
            weatherStation.Temperature = 28f;
            weatherStation.Temperature = 27.5f;
            weatherStation.Temperature = 30.7f;

            Console.ReadLine();
        }
    }
}
