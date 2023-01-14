using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Web Page Administrator";
        job1._company = "Clydesdale Horse Farm";
        job1._startYear = "2019";
        job1._endYear = "2023";

        Job job2 = new Job();
        job2._company = "Amazing Baking";
        job2._jobTitle = "Baker";
        job2._startYear = "2021";
        job2._endYear = "2023";

        // Console.WriteLine($"Job Title: {job1._jobTitle} Company:({job1._company}) Duration: {job1._startYear} - {job1._endYear}.");

        Resume resume1 = new Resume();
        resume1._name = "Allison Lovell";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
        
    }
    
}