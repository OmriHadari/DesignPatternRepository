using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Nano : BasicCar
    {
        public Nano(string name)
        {
            ModelName = name;
        }

        public override BasicCar Clone()
        {
            return (Nano)this.MemberwiseClone();
        }
    }
}
