using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorCAT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                double height = 0;
                double weight = 8;
                double BMI;
                

                if (height <= 0)
                    throw new Exception("Height should not be 0 or less than 0.");

                BMI = weight / Math.Pow(height, 2);
                if (BMI > 30)
                    Console.WriteLine("Obesity");
                else if (BMI >= 25 && BMI <= 29.9)
                    Console.WriteLine("Over weight");
                else if (BMI >= 18.5 && BMI <= 24.9)
                    Console.WriteLine("Normal weight");
                else
                    Console.WriteLine("Under weight");
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
