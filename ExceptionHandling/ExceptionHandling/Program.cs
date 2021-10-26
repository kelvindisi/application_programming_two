using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius, area;
            bool reenter = true;
            do
            {
                try
                {
                    Console.Write("Enter radius: ");
                    radius = float.Parse(Console.ReadLine());

                    area = (float)(Math.PI * Math.Pow(radius, 2));
                    Console.WriteLine("Area of circle is {0}", area);
                    reenter = false;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("This was not an integer, type an integer");
                }
                finally
                {
                    Console.WriteLine("Objective is to compute are of a circle");
                }
            }while (reenter);


            Console.ReadKey();
        }
    }
}
