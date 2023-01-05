using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();

        int input = -1;
        while (input != 0)
        {
            Console.Write("Enter numbers and type 0 to quit: ");

            string userInput = Console.ReadLine();
            input = int.Parse(userInput);

            if (input != 0)
            {
                nums.Add(input);
            }
        }

        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");
        
    }
}