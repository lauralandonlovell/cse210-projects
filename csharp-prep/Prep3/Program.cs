using System;

class Program
{
    static void Main(string[] args)
    {
        int mnumber = 6;
        int guess = -1;
        while (guess != mnumber)
        {
            Console.WriteLine("What is the magic number?");
            Console.WriteLine(mnumber);
        
            Console.Write("What is your guess? ");
            int guess = Convert.ToInt32(Console.ReadLine());
        
            if (guess < mnumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > mnumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
        
    }
    
}