using SimpleFactory.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.AbstractFactory
{
    public class WildAnimalFactory : IAbstractAnimalFactory
    {
        public ICat GetCat()
        {
            return new WildCat();
        }

        public IDog GetDog()
        {
            return new WildDog();
        }
    }
}
