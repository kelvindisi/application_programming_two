using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();
            staff.getDetails();
            staff.printDetails();


            Console.ReadKey();
        }
    }
}
