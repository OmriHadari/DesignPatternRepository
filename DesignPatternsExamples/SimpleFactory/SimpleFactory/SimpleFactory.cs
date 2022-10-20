using SimpleFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SimpleFactory : ISimpleFactory
    {
        public override IAnimal CreateAnimal(int animalNumber)
        {
            IAnimal animal = null;

            switch (animalNumber)
            {
                case 0:
                    animal = new Dog();
                    break;
                case 1:
                    animal = new Cat();
                    break;
                default:
                    break;
            }

            return animal;
        }
    }
}
