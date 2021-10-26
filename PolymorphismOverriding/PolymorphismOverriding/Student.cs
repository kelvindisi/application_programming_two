using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverriding
{
    class Student: Person
    {
        private string regNo;

        public Student(string name, int age, string regNo)
        {
            this.name = name;
            this.age = age;
            this.regNo = regNo;
        }

        public override void print()
        {
            base.print();
            Console.WriteLine("Registration No: {0}", regNo);
        }
    }
}
