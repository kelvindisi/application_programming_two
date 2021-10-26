using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Person
    {
        protected string firstName;
        protected string surname;
        protected string gender;

        public abstract void getDetails();
        public virtual void print()
        {
            Console.WriteLine("Full Name: {0} {1}\nGender: {3}", firstName, surname, gender);
        }
    }
}
