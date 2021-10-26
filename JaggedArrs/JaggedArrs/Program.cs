using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrs
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][]arr = new int[3][];

            arr[0] = new int[] { 45, 46, 47 };
            arr[1] = new int[] { 54 };
            arr[2] = new int[] { 50, 51, 52, 53, 54 };


            for(int i=0; i<arr.Length; i++)
            {
                for (int c=0; c<arr[i].Length; c++)
                {
                    Console.Write(arr[i][c] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
