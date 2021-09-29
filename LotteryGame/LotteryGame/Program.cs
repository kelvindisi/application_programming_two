using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, inputX, inputY;

            Random random = new Random();
            x = random.Next(10, 99);
            y = random.Next(10, 99);

            Console.WriteLine("Guess first number: ");
            inputX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Guess second number: ");
            inputY = Convert.ToInt32(Console.ReadLine());

            if (x == inputX && y == inputY)
                Console.WriteLine("You have won 10,000.");
            else if (x == inputY && y == inputX)
                Console.WriteLine("You have won 3,000.");
            else if (x == inputX || y == inputY || x == inputY || y == inputX)
                Console.WriteLine("You have won 1,000.");
            else
                Console.WriteLine("Sorry you haven't won anything, winning numbers are {0}, {1}.", x, y);


            Console.ReadKey();
        }
    }
}
