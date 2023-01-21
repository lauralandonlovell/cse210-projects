using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args) {

        int i = 1;
        while (i<=5)
        {
            Console.WriteLine("C# For Loop: Iteration {0}, i");
            Console.WriteLine("Keep track of your day! Choose one of the following actions:");
            Console.WriteLine("1. LunchBreak Entry");
            Console.WriteLine("2. Write");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Read");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Quit");
            i++;
        }
        
    }
    
}