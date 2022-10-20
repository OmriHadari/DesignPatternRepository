using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implementations
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> _observers;
        public float Temperature
        {
            get { return _temperature; }
            set 
            { 
                _temperature = value;
                Notify();
            }
        }

        private float _temperature;

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }

        public void Notify()
        {
            _observers.ForEach(o =>
            {
                o.Update(this);
            });
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }
    }
}
