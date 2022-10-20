using SimpleFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Cat meow.");
        }

        public void Action()
        {
            Console.WriteLine("Cat licks ass.");
        }
    }
}
