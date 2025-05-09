// This program prompts the user for their name and favorite number, squares the number, and displays the result.
using System;

class Program
{
    static void Main(string[] args)
    {
         DisplayWelcomeMessage();

         string userName = PromptUserName();
         int userNumber = PromptUserNumber();

         int squaredNumber = SquareNumber(userNumber);

         DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");

    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter favourite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is: {squaredNumber}");

    }

}