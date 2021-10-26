using System;
using System.Collections;
using System.Linq;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            arr.Add(54);
            arr.AddRange(new int[] { 56, 55, 57 });
            arr.Add("Seth");
            arr.Add("Francis");
            arr.AddRange(new double[] { 32.64, 38.98, 49.66 });

            ArrayList doubleType = new ArrayList();
            ArrayList stringType = new ArrayList();
            ArrayList intType = new ArrayList();

            arr[arr.IndexOf("Francis")] = "Franco";

            //arr.RemoveAt(5);
            //arr.Insert(5, "Franco");
            foreach(var val in arr)
            {
                Type t = val.GetType();

                if (t.Equals(typeof(int)))
                    intType.Add(val);
                else if (t.Equals(typeof(double)))
                    doubleType.Add(val);
                else if (t.Equals(typeof(string)))
                    stringType.Add(val);
            }
            Console.WriteLine("Double Elements:");

            doubleType.Cast<double>().ToList().ForEach(d => Console.Write(d + "\t"));
            
            Console.WriteLine();
            Console.WriteLine("String Elements");
            stringType.Cast<string>().ToList().ForEach(s => Console.Write(s + "\t"));

            Console.WriteLine();
            Console.WriteLine("Integer Elements");
            intType.Cast<int>().ToList().ForEach(i => Console.Write(i + "\t"));


            Console.ReadKey();
        }
    }
}
