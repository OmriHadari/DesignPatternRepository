using SimpleFactory.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.AbstractFactory
{
    public class WildCat : ICat
    {
        public void Speak()
        {
            Console.WriteLine("Wild cat says hissssss.");
        }

        public void Action()
        {
            Console.WriteLine("Pet cat hunt.");
        }
    }
}
