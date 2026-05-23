using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Jijones";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2026";
        job1._endYear = "2028";

        Job job2 = new Job();
        job2._company = "El Chacho";
        job2._jobTitle = "Carpenter";
        job2._startYear = "2029";
        job2._endYear = "3000";

        Resume firstLine = new Resume();
        firstLine.jobList.Add(job1);
        firstLine.jobList.Add(job2);
        

        Console.Write("Name: ");
        string name = Console.ReadLine();
        firstLine._personName = name;
        firstLine.ShowJobs();
    }
}