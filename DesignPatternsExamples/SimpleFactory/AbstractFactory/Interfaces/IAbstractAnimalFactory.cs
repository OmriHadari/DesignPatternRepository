using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.AbstractFactory.Interfaces
{
    public interface IAbstractAnimalFactory
    {
        IDog GetDog();
        ICat GetCat();
    }
}
