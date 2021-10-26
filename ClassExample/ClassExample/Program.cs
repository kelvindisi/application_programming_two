using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.getDetails();
            //student.print();
            int a, b, c;
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            c = Convert.ToInt32(Console.ReadLine());

            House.alterValues(ref a, ref b, ref c);

            Console.WriteLine("A: {0}\nB: {1}\nC: {2}", a, b, c);

            Console.ReadKey();
        }
    }
}
