using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.getDetails();
            course.printDetails();

            Console.ReadKey();
        }
    }
}
