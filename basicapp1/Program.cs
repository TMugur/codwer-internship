using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicapp1
{
   class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number with least 3 digits: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number < 100)
            {
                Console.WriteLine("The number have less than 3 digits. Enter another number.");
                input = Console.ReadLine();
                number = int.Parse(input);
            }
            int reversNumber = 0;
            while (number > 0)
            {
                int num = number % 10;
                reversNumber = reversNumber *10 + num;
                number /= 10;
            }
            int square = (int)Math.Sqrt(reversNumber);
            if (square * square ==reversNumber)
            {
                Console.WriteLine("This number is perfect square.");
            }
            else
            {
                Console.WriteLine("This number is not perfect square.");
            }
        }
    }
}
