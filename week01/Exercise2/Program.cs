using System;

Console.Write("Whats your grade percentage? ");
string gradeInput = Console.ReadLine();
double gradePercentage = double.Parse(gradeInput);

if (gradePercentage < 70 || gradePercentage == 100)
{
    if (gradePercentage >= 90)
    {
        Console.WriteLine("Your letter grade is: A");
    }
    else if (gradePercentage >= 80)
    {
        Console.WriteLine("Your letter grade is: B");
    }
    else if (gradePercentage >= 70)
    {
        Console.WriteLine("Your letter grade is: C");
    }
    else if (gradePercentage >= 60)
    {
        Console.WriteLine("Your letter grade is: D");
    }
    else
    {
        Console.WriteLine("Your letter grade is: F");
    }
}
else
{
    Console.WriteLine("Invalid grade percentage. Please enter a value between 0 and 100.");
}