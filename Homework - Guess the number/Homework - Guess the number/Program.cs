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
            Random randomNumber = new Random();
            int numberToGuess = randomNumber.Next(0, 100);
            int tries = 0;
            bool isGuessed = false;

            Console.WriteLine("You have 10 tries to guess the number. Enter a number.");
            int inputNumber = int.Parse(Console.ReadLine());

            while (tries < 9 && isGuessed==false)
            {
                tries++;
                if (inputNumber < numberToGuess)
                {
                    Console.WriteLine("Number is too small. You have {0} tries left. Enter another number: ", 10 - tries);
                    inputNumber = int.Parse(Console.ReadLine());
                }
                else if (inputNumber > numberToGuess)
                {
                    Console.WriteLine("Number is too big. You have {0} tries left. Enter another number: ", 10 - tries);
                    inputNumber = int.Parse(Console.ReadLine());
                }
                else
                {
                    isGuessed = true;
                }
            }

            if (isGuessed == true)
            {
                Console.WriteLine("Yuhuu! You guessed the number!");
            }
            else
            {
                Console.WriteLine("Sorry! You've reached the max number of tries. The number was: {0}", numberToGuess);
            }
            
        }
    }
}
