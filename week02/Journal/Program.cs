using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is an A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is a B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is a C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is a D.");
        }
        else if (gradePercentage < 60)
        {
            Console.WriteLine("Your letter grade is an F.");
        }
        else
        {
            Console.WriteLine("Invalid grade percentage.");
        }
         
    }
}