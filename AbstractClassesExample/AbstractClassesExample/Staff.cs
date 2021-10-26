using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesExample
{
    class Staff: Person
    {
        private string department;

        public override void getDetails()
        {
            Console.Write("Enter full name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter deparment: ");
            department = Console.ReadLine();
        }

        public override void printDetails()
        {
            Console.WriteLine("Staff name is {0} who is {1} years old works at {2} department", name, age, department);
        }
    }
}
