using SimpleFactory.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.AbstractFactory
{
    public class WildDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Wild dog says grrrr.");
        }

        public void Action()
        {
            Console.WriteLine("Wild dog hunt.");
        }
    }
}
