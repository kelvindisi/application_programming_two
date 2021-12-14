using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person patient = new Patient();
            patient.CaptureDetails();
            patient.displayResults();


            Console.ReadKey();
        }
    }
}
