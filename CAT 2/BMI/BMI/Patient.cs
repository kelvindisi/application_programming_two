using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Patient: Person
    {
        public override void displayResults()
        {
            Console.WriteLine("{0} is {1} years old with height {2}mtrs "
                + "and weight {3}kgs has BMI status is {4}",
                name, computeAge(), height, weight, computeStatus());
        }
        private int computeAge()
        {
            int age;

            age = (DateTime.Now.Year - date_of_birth.Year);

            return age;
        }
        private string computeStatus()
        {
            double BMI;

            BMI = weight / Math.Pow(height, 2);

            if (BMI < 18.5)
                return "Underweight";
            else if (BMI >= 18.5 && BMI < 25.0)
                return "Normal";
            else if (BMI >= 25.0 && BMI < 30.00)
                return "Overweight";
            else
                return "Obese";
        }
    }
}
