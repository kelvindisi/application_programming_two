using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemparatureNurse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            double[,] readings = new double[5, 4];

            for (int i=0; i<names.Length; i++)
            {
                Console.Write("Enter patient name: ");
                names[i] = Console.ReadLine();

                for (int c=0; c<4; c++)
                {
                    Console.Write("Enter patient {0} reading {1}: ", i + 1, c + 1);
                    readings[i, c] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Patient\t\t\tR1\tR2\tR3\tR4\tAverage");
            for (int i=0; i<names.Length; i++)
            {
                Console.Write("{0}\t\t", names[i]);
                double total = 0, average = 0;
                for(int c=0; c<4; c++)
                {
                    Console.Write("{0}\t", readings[i, c]);
                    total += readings[i, c];
                }

                average = total / 4;
                Console.WriteLine("{0}", average);
            }

            Console.ReadKey();
        }
    }
}
