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
            int mnumber = int.Parse(Console.ReadLine());
        
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
                Console.WriteLine("Congratulations! You guessed it!");
            }
        }
        
        
    }
    
}