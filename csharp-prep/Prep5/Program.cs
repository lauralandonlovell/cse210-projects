using System;
class Program
{    
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName(string first, string last);

        int fnumber = PromptUserNumber();

        int carre = SquareNumber(fnumber);

        DisplayResult(string name, int carre);
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
    static int PromptUserNumber(int number)
    {
        Console.Write("What is your favorite number? ");
        int favnumber = int.Parse(Console.ReadLine());

        int fnumber = int.Parse($"{favnumber} is your favorite number!");

        return fnumber;
    }

    static int SquareNumber(int number)
    {
        int carre = number * number;
        return carre;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, your favorite number squared is {square}");
    }
}