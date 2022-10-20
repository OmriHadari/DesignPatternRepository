using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void Notify();
    }
}
