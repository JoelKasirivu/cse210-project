using System;

class Program
{
    static void Main(string[] args)
    {
        // This program asks the user for their first and last name and then prints it in a specific format.
        // The format is: "Your name is: <last name>, <last name> <first name>"
        Console.Write("What is your first name: ");
        string first = Console.ReadLine();
        

        Console.Write("What is your last name: ");
        string last = Console.ReadLine();
        

        Console.WriteLine($"Your name is:{last}, {first} {last}");




    }
}