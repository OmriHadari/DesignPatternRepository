using SimpleFactory.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.AbstractFactory
{
    public class PetCat : ICat
    {
        public void Speak()
        {
            Console.WriteLine("Pet cat says meow.");
        }

        public void Action()
        {
            Console.WriteLine("Pet cat licks ass.");
        }
    }
}
