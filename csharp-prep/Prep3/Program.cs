using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mnumber = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != mnumber)
        {
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
        
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