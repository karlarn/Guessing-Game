using System;
using System.Collections.Generic;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number!");
            int secretNumber = new Random().Next(1,101);
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(secretNumber);
                Console.WriteLine($"You have 4 guesses. You're on {i}.");
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
