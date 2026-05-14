using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = number;
        int count = 1;
        int average = 0;
        int largest = number;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            sum += number;
            count++;
            if (number > largest)
            {
                largest = number;
            }
        }
        average = sum / (count - 1);

        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}