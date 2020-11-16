using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int GuessCount = 0;
            Console.WriteLine("Time to guess the secret number!");
            Console.WriteLine("What is your guess?");
            int SecretNumber = 42;
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
                    }
                    else
                    {
                        Console.WriteLine("nope... try again");
                        Console.WriteLine($"you've made {GuessCount} guesses");
                        Console.WriteLine("What is your guess?");
                        guess = int.Parse(Console.ReadLine());
                    };
                }
            }
            Console.WriteLine("thanks for playing");
        }
    }
}

// guescount=1
// write guess
// while !=secret && guesscount<3
// Console guess
// guess = ReadO
// guescount ++
// }
// if guessCount = 3