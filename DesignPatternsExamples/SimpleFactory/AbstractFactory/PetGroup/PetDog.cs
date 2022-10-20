using SimpleFactory.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.AbstractFactory
{
    public class PetDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Pet dog says woof.");
        }

        public void Action()
        {
            Console.WriteLine("Pet dog play fetch.");
        }
    }
}
