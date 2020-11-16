using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int GuessCount = 0;
            Console.WriteLine("Time to guess the secret number!");
            Console.WriteLine("Choose your Difficulty Level");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.WriteLine("4. Cheater");
            int GuessLimit = 0;
            int UserChoice = int.Parse(Console.ReadLine());
            switch (UserChoice)
            {
                case 1:
                    GuessLimit = 8;
                    break;
                case 2:
                    GuessLimit = 6;
                    break;
                case 3:
                    GuessLimit = 4;
                    break;
                case 4:
                    GuessLimit = 99999999;
                    break;
            }
            Console.WriteLine($"You get {GuessLimit} guesses");
            Console.WriteLine("What is your guess?");
            int SecretNumber = new Random().Next(1, 101); ;
            int guess = int.Parse(Console.ReadLine());
            while (GuessCount < GuessLimit)
            {
                GuessCount++;
                if (guess == SecretNumber)
                {
                    Console.WriteLine("you got it!");
                    Console.WriteLine($"You used {GuessCount} of your {GuessLimit} guesses");
                    GuessCount = GuessLimit;
                }
                else
                {
                    if (GuessCount == GuessLimit)
                    {
                        Console.WriteLine($"That was guess number {GuessCount} of {GuessLimit}");
                        Console.WriteLine("You're out of guesses... too bad...");
                        Console.WriteLine($"The number was {SecretNumber}");
                    }
                    else
                    {
                        Console.WriteLine("nope... try again");
                        Console.WriteLine($"you've made {GuessCount} of {GuessLimit} guesses");
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