using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "Pacific Computers";
        job1._jobTitle = "Executive istructor";
        job1._startYear = 2014;
        job1._endYear = 2015;


        Job job2 = new Job();
        job2._company = "BYU Idaho";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2023;
        job2._endYear = 2024;

       

        Resume resume = new Resume();
        resume._personesName = "Adekoya Ayeni";

        resume._jobList.Add(job2);
        resume._jobList.Add(job1);

        resume.Display();


    }

    

}
