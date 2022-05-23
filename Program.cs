using System;
using System.Collections.Generic;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number!");
            int secretNumber = 42;
            for (int i = 0; i < 4; i++)
            {
                int guess = Int32.Parse(Console.ReadLine());
                if (guess == secretNumber)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, wrong number.");

                }
            }
        }
    }
}
