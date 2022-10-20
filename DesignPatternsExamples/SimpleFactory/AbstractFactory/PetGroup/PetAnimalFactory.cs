using SimpleFactory.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.AbstractFactory
{
    public class PetAnimalFactory : IAbstractAnimalFactory
    {
        public ICat GetCat()
        {
            return new PetCat();
        }

        public IDog GetDog()
        {
            return new PetDog();
        }
    }
}
