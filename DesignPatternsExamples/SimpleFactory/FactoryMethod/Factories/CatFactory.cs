using SimpleFactory.FactoryMethod.Interfaces;
using SimpleFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.FactoryMethod
{
    public class CatFactory : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }
}
