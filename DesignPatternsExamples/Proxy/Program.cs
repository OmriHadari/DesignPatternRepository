using System;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public interface Abstraction { }

        public class Concretion : Abstraction { }

        public class ProxyConcretion : Abstraction
        {
            // Hide concretion, injecting = exposing.
            // Compile time decision.
            Concretion concretion = new Concretion();
        }

        public class ConcretionDecorator : Abstraction
        {
            Abstraction _abstraction;

            // Concretion is known
            // Runtime decision.
            public ConcretionDecorator(Abstraction abstraction)
            {
                _abstraction = abstraction;
            }
        }
    }
}
