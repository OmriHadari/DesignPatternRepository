using System;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public abstract class Place
        {
            public abstract void Visit(Visitor visitor);
        }

        public abstract class Visitor
        {
            public abstract void VisitPark(Park park);
            public abstract void VisitHome(Home home);
        }

        public class Park : Place
        {
            public override void Visit(Visitor visitor)
            {
                visitor.VisitPark(this);
            }
        }

        public class Home : Place
        {
            public override void Visit(Visitor visitor)
            {
                visitor.VisitHome(this);
            }
        }

        public class Dude : Visitor
        {
            public override void VisitHome(Home home) => Console.WriteLine("Play video game.");

            public override void VisitPark(Park park) => Console.WriteLine("Have a picnik.");
        }

        public class Robber : Visitor
        {
            public override void VisitHome(Home home) => Console.WriteLine("Steal TV.");

            public override void VisitPark(Park park) => Console.WriteLine("Smoke weed.");
        }
    }
}
