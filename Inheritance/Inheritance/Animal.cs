using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        protected int legs;
        protected string name;

        public void print()
        {
            Console.WriteLine("Animal {0} has {1} legs.", name, legs);
        }
    }
}
