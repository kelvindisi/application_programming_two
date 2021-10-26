using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class House
    {
        public static void alterValues(ref int x, ref int y, ref int z)
        {
            x = x + (int)(x * 0.1);
            y = y * 100;
            z = z - 50;
        }
    }
}
