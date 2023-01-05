using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is the magic number?");
        
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();

        int mnumber = 6;
        if ((Convert.ToInt16(guess)) < mnumber)
        {
            Console.WriteLine("Higher!");
        }
        else if (guess > mnumber)
        {
            Console.WriteLine("Lower!");
        }
        
    }
    
}