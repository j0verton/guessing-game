using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to guess the secret number!");
            Console.WriteLine("What is your guess?");
            int SecretNumber = 42;
            int guess = int.Parse(Console.ReadLine());
            while (guess != SecretNumber)
            {
                Console.WriteLine("try again");
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("you got it!");
        }
    }
}
