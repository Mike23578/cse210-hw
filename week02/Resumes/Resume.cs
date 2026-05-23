public class Resume
{
    public List<Job> jobList = new List<Job>();
    internal string _personName;

    public void ShowJobs ()
   {    
        Console.WriteLine("Jobs:");

        for (int i = 0; i < jobList.Count; i++)
        {
            jobList[i].DisplayJobDetails ();
        }
    } 

}