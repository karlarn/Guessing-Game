using System;
using System.Collections.Generic;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number!");
            int guess= Int32.Parse(Console.ReadLine());
            Console.WriteLine(guess);
        }
    }
}
