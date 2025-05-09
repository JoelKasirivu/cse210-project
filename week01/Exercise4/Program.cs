using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        // collect numbers from the user
        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int num;
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("Invalid input. Plaease enter a number.");
                continue; 
                // Skip to the next iteration of the loop
            }

            if (num == 0) break; // Exit the loop if the user enters 0
            numbers.Add(num); // Add the number to the list
        }

        // Compute sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num; // Add each number to the sum
        }
        Console.WriteLine($"The sum is: {sum}");

        // Compute average
        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
        Console.WriteLine($"The average is: {average}");
        // Find the largest number
        int max = numbers.Count > 0 ? numbers[0] : 0;
        foreach (int num in numbers)
        {
            if (num > max) max = num;
        }
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge: Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num; // Update smallest positive number
            }
        }
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        
        }

        // Stretch challenge: Sort the numbers and display
        numbers.Sort(); // Sort the list of numbers
        Console.WriteLine("Sorted numbers: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num); // Print each number in the sorted list
        }

    }
}