using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Question
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start number and end number");
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime Numbers between {min} and {max} are");
            Console.WriteLine("My name is Pramila Srinivasan");
            for (int i = min; i <= max; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0 && i != 1)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
