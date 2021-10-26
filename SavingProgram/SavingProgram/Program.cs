using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Saving saving = new Saving(50, 1, 1);
            saving.input();
            saving.compute();
            saving.display();

            Console.ReadKey();
        }
    }
}
