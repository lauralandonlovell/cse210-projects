using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep 5 World!");
        
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(string first, string last)
    {
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        string name = ($"{fname} {lname}");
        return name;
    }
}