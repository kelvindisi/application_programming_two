using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    abstract class Person
    {
        protected string name;
        protected double height, weight;
        protected DateTime date_of_birth;

        public void CaptureDetails()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter weight: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter date of birth: ");
            date_of_birth = Convert.ToDateTime(Console.ReadLine());
        }

        public abstract void displayResults();
    }
}
