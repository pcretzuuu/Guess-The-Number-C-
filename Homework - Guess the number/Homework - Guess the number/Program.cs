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
            int t = 0;
            bool ok = false;

            Console.WriteLine("You have 10 tries to guess the number. Enter a number.");
            int n = int.Parse(Console.ReadLine());

            while (t < 9 && ok==false)
            {
                t++;
                if (n < g)
                {
                    Console.WriteLine("Number is too small. You have {0} tries left. Enter another number: ", 10-t);
                    n = int.Parse(Console.ReadLine());
                } else if (n > g)
                {
                    Console.WriteLine("Number is too big. You have {0} tries left. Enter another number: ", 10 - t);
                    n = int.Parse(Console.ReadLine());
                } else
                {
                    ok = true;
                }
            }

            if (ok == true) {
                Console.WriteLine("Yuhuu! You guessed the number!");
            } else
            {
                Console.WriteLine("Sorry! You've reached the max number of tries. The number was: {0}", g);
            }
            
        }
    }
}
