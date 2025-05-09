using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        // Convert the input to an integer
        int gradePercentage;
        if (!int.TryParse(input, out gradePercentage))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        // Determine the letter grade based on the percentage
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the "+" or "-" sign
        string sign = "";
        int lastDigit = gradePercentage % 10;
        if (letter != "A" && letter != "F") // Only add sign for grades other than A and F
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }
        }

        // Print the letter grade with the sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // congratulate the student
        

    
    }
}
        

    