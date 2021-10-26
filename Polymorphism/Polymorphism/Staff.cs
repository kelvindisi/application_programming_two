using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Staff: Person
    {
        private string department;
        private int salary;

        public override void getDetails()
        {
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter gender: ");
            gender = Console.ReadLine();
            Console.WriteLine("Enter department: ");
            department = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public override void print()
        {
            Console.WriteLine("From child class");
        }
    }
}
