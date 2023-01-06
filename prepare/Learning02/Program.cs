using System;

class Program
{
    static void Main(string[] args)
    {
        string job1 = new Job();
        string job1._jobTitle = "Web Page Administrator";
        string job1._company = "Clydesdale Horse Farm";
        int job1._startYear = "2019";
        int job1._endYear = "2023";

        string job2 = new Job();
        string job2._company = "Amazing Baking";
        string job2._jobTitle = "Baker";
        int job2._startYear = "2021";
        int job2._endYear = "2023";

        Console.WriteLine($"Job Title: {job1._jobTitle} Company:({job1._company}) Duration: {job1._startYear} - {job1._endYear}.");
    }
}