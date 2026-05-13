using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        string letter = "";

        if (gradePercentage >=70)
        {
            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
        }

        else if (gradePercentage <= 69)
        {
            if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else if (gradePercentage < 60)
            {
                letter = "F";
            }
            else
            {
                Console.WriteLine("Invalid grade percentage.");
            }
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class.");
        }
    }
}