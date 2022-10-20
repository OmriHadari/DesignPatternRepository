using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Ford : BasicCar
    {
        public Ford(string name)
        {
            ModelName = name;
        }

        public override BasicCar Clone()
        {
            return (Ford)MemberwiseClone();
        }
    }
}
