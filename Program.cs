using System;
using System.Collections.Generic;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your difficulty: Easy, Medium, Hard.");
            string difficulty=Console.ReadLine().ToLower();
            int numberToGuess=0;
            if (difficulty=="easy"){
                 numberToGuess=8;
            }
            else if(difficulty=="medium"){
                numberToGuess=6;
            }
            else if(difficulty=="hard"){
                numberToGuess=4;
            }
            Console.WriteLine("Guess the secret number!");
            int secretNumber = new Random().Next(1,101);
            for (int i = 1; i <= numberToGuess; i++)
            {
                Console.WriteLine($"You have {numberToGuess} guesses. You're on {i}.");
                int guess = Int32.Parse(Console.ReadLine());
                if (guess == secretNumber)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else
                {
                    if(secretNumber>guess){
                        Console.WriteLine("Guess higher!");
                    }
                    else{
                        Console.WriteLine("Guess lower!");
                    }

                }
            }
        }
    }
}
