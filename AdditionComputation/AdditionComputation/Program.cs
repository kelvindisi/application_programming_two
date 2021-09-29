using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, total, value;
            int count = 0;

            Random rand = new Random();
            x = rand.Next(0, 9);
            y = rand.Next(0, 9);
            total = x + y;

            Console.WriteLine("What is {0} + {1}? ", x, y);
            while(count < 5)
            {
                value = Int32.Parse(Console.ReadLine());
                if (value == total)
                {
                    Console.WriteLine("Correct");
                    break;
                } else
                {
                    Console.WriteLine("Incorrect, try again");
                    if (count == 4)
                    {
                        Console.WriteLine("The correct answer of {0}+{1} is {2}", x, y, total);
                    }
                }
                count += 1;
            }

            Console.ReadKey();
        }
    }
}
