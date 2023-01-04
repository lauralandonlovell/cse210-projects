using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write('What is your grade percentage? ');
        string input = Console.ReadLine();
        int percent = int.Parse(input);
        string grade = '';
        
        if (percent >= 90)
        {
            grade = 'A';
        }
        else if (percent >= 80)
        {
            grade = 'B';
        }
        else if (percent >= 70)
        {
            grade = 'C';
        }
        else if (percent >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        Console.WriteLine($'Your grade is: {grade}.');

        if (percent >= 70)
        {
            Console.WriteLine('You passed!!!!!');
        }
        else
        {
            Console.WriteLine('Keep Trying!');
        }
    }
}