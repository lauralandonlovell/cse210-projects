using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args) 
    {
/*reading https://www.c-sharpcorner.com/UploadFile/75a48f/list-collection-class-in-C-Sharp/ and https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-in-C-Sharp/  helped me create new list*/
        int i = 1;
        while (i <= 6)

        {
            string input;
            Console.WriteLine("Welcome to the Journal Program. Enjoy keeping track of your day!");
            string[] menuOptions = {
                "1. LunchBreak Entry",
                "2. Write",
                "3. Display",
                "4. Read",
                "5. Save",
                "6. Quit",

            };
            foreach (var option in menuOptions)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine("Please enter a number from the menu above:");
            input = Console.ReadLine();//switch statement programiz.com

            // if (input != "1")
            // {
            //     i++;

            // }
            // else
            // {
            //     break;

            // }
        }


    }
    
}