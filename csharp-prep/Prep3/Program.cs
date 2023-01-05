using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is the magic number?");
        
        Console.Write("What is your guess? ");
        int guess = Console.ReadLine();

        int mnumber = 6;
        if (guess < mnumber)
        {
            Console.WriteLine("Higher!");
        }
        else if (guess > mnumber)
        {
            Console.WriteLine("Lower!");
        }
        
    }
    
}