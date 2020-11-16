using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to guess the secret number!");
            Console.WriteLine("What is your guess?");

            string guess = Console.ReadLine();
            Console.WriteLine(guess);
        }
    }
}
