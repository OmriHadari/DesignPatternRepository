using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implementations
{
    public class NewsAgency : IObserver
    {
        public string AgencyName { get; set; }

        public NewsAgency(string name)
        {
            AgencyName = name;
        }

        public void Update(ISubject subject)
        {
            if (subject is WeatherStation weatherStation)
            {
                Console.WriteLine(
                    String.Format
                    (
                        "{0} reporting temperature {1} degrees",
                        AgencyName,
                        weatherStation.Temperature.ToString()
                    ));
                Console.WriteLine("******************************");
            }
        }
    }
}
