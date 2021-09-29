using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;

            do
            {
                Console.WriteLine("****************{0}****************", x);
                y = 1;
                do
                {
                    Console.WriteLine("{0} * {1} = {2}", x, y, (x * y));
                    y += 1;
                } while (y <= 7);
                x += 1;
            } while (x <= 7);

            Console.ReadKey();
        }
    }
}
