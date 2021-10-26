using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesExample
{
    abstract class Person
    {
        protected string name;
        protected int age;

        public abstract void getDetails();
        public abstract void printDetails();
    }
}
