﻿using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int GuessCount = 0;
            Console.WriteLine("Time to guess the secret number!");
            Console.WriteLine("What is your guess?");
            int SecretNumber = new Random().Next(1, 101); ;
            int guess = int.Parse(Console.ReadLine());
            while (GuessCount < 4)
            {
                if (guess == SecretNumber)
                {
                    Console.WriteLine("you got it!");
                    GuessCount = 4;
                }
                else
                {
                    GuessCount++;
                    if (GuessCount == 4)
                    {
                        Console.WriteLine($"That was guess number {GuessCount}");
                        Console.WriteLine("You're out of guesses... too bad...");
                        Console.WriteLine($"The number was {SecretNumber}");
                    }
                    else
                    {
                        Console.WriteLine("nope... try again");
                        Console.WriteLine($"you've made {GuessCount} guesses");
                        if (guess < SecretNumber)
                        {
                            Console.WriteLine($"{guess} is less than the Secret Number");
                            Console.WriteLine("What is your guess?");
                            guess = int.Parse(Console.ReadLine());
                        }
                        else if (guess > SecretNumber)
                        {
                            Console.WriteLine($"{guess} is greater than the Secret Number");
                            Console.WriteLine("What is your guess?");
                            guess = int.Parse(Console.ReadLine());
                        }
                    };
                }
            }
            Console.WriteLine("thanks for playing");
        }
    }
}
//secert num = 1
//write guess
// guescount=0
// guess= read

// while !=secret && guesscount<3
// Console write guess
// guescount ++
//write guesscount of 4
// guess = Read
// }

// if guessCount = 3 or guess == sercret
//write correct
//else
//write out of tries