using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int g = r.Next(0, 100);

            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            while (n!=g)
            {
                if (n < g)
                {
                    Console.WriteLine("Number is too small. Enter another number: ");
                    n = int.Parse(Console.ReadLine());
                } else
                {
                    Console.WriteLine("Number is too big. Enter another number: ");
                    n = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Yuhuu! You guessed the number!");
        }
    }
}
