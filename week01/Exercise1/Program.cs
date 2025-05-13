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
        Console.WriteLine("What is your favourite color: ");
        string color = Console.ReadLine();
        Console.WriteLine($"Your favourite color is: {color}");

        Console.WriteLine("How old are you?: ");
        // Assuming the user will enter an integer for age
        // You might want to add error handling for non-integer inputs
        // int age = int.Parse(Console.ReadLine());
        // For simplicity, let's just read it as a string for now
        // string age = Console.ReadLine();
        // If you want to convert it to an integer, uncomment the line below
        int age = int.Parse(Console.ReadLine());
        // If you want to keep it as a string, just use the line below
        //int age = Console.ReadLine();

        Console.WriteLine($"You are {age} years old.");

        Console.WriteLine("What is your favourite food: ");
        string food = Console.ReadLine();
        Console.WriteLine($"Your favourite food is: {food}");




    }
}