using System;

public class Job
{
     public string _company = "";
     public string _jobTitle = "";
     public int _startYear = 0;
     public int _endYear = 0;


    //  a method (member function) to display the job details
     public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
     
}