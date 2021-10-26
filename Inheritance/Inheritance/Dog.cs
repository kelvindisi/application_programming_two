using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog: Animal
    {
        public Dog(string name, int legs)
        {
            this.name = name;
            this.legs = legs;
        }
    }
}
