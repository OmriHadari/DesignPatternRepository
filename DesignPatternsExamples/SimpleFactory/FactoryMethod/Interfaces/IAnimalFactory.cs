using SimpleFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.FactoryMethod.Interfaces
{
    public abstract class IAnimalFactory
    {
        public abstract IAnimal CreateAnimal();
        public IAnimal CreateAnimalBeautified()
        {
            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();
            return animal;
        }
    }
}
