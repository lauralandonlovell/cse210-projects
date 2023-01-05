using System;

class Program
{
    static void Main(string[] args)
    {
        int mnumber = 6;
        Console.WriteLine("What is the magic number?");
        
        Console.Write("What is your guess? ");

        int guess = Console.ReadLine();

        if (guess === mnumber)
        {
            Console.WriteLine("You guessed it on your first try! Congratulations!!");
        }
        
    }
    
}