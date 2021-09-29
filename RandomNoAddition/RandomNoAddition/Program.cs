using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNoAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int no, x, y, z, rem, total;

            Random random = new Random();
            no = random.Next(100, 1000);

            x = no / 100;
            rem = no % 100;
            y = rem / 10;
            z = rem % 10;
            total = x + y + z;

            Console.WriteLine("Random value {0} has a total {1}", no, total);
            Console.ReadKey();
        }
    }
}
