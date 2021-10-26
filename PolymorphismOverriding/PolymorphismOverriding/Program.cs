using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Francis Mwakideu", 70, "SCT221-0770/2018");
            student.print();


            Console.ReadKey();
        }
    }
}
