using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverriding
{
    class Person
    {
        protected string name;
        protected int age;

        public virtual void print()
        {
            Console.WriteLine("The person age is {0} and is {1} years old", name, age);
        }
    }
}
