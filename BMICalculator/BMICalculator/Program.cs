using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const float POUND_KILOGRAM= (float) 0.45359237;
            const float INCH_METRE = (float)0.0254;

            float weightPound, heightInches, weightKilogram, heightMetres, BMI;

            Console.WriteLine("Enter weight in pounds: ");
            weightPound = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height in inches: ");
            heightInches = float.Parse(Console.ReadLine());

            weightKilogram = weightPound * POUND_KILOGRAM;
            heightMetres = heightInches * INCH_METRE;

            BMI = weightKilogram / (float)Math.Pow(heightMetres, 2);

            if (BMI >= 30)
                Console.WriteLine("Obese");
            else if (BMI >= 25 && BMI < 30)
                Console.WriteLine("Overweight");
            else if (BMI >= 18.5 && BMI < 25)
                Console.WriteLine("Normal");
            else
                Console.WriteLine("Underweight");

            Console.ReadKey();
        }
    }
}
