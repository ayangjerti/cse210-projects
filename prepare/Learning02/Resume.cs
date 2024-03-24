using System;

public class Resume
{
     public string _personesName = "";
     public List<Job> _jobList = new List<Job>();

     public void Display()
     {
        Console.WriteLine($"Name: {_personesName}");
        Console.WriteLine("Jobs: ");
        // Console.WriteLine($"{_jobList}");
        if (_jobList != null)
        {
            // Iterate through the list and display each element
            foreach (Job job in _jobList)
            {
                // Console.WriteLine($"{job}");
                job.Display();
            }
        }
        else
        {
            Console.WriteLine("The list is null.");
        }
     }
}