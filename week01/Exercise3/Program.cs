using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guessedNumber = 0;

        do
        {

            Console.Write("What is your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());
            if (number == guessedNumber)
            
            {
                Console.WriteLine("You guessed the magic number!");
            }
            else if (guessedNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessedNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Sorry, that's not the magic number.");
            }

        } while (number != guessedNumber);
    }
}