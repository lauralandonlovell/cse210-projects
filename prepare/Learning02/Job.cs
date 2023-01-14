using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startYear;
    public string _endYear;

    public void Display()
    {
        Console.WriteLine($"My name is Allison Lovell, and I have experience in the role of {_jobTitle} working for {_company} from {_startYear} until {_endYear}.");
    }

}