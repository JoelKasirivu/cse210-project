using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        // This program allows users to engage in mindfulness activities such as breathing, reflection, and listing.
        Console.WriteLine("Welcome to the Mindfulness Program!");
        while (true)
        // Main menu loop to allow users to select activities
        // The program will continue to run until the user chooses to exit.
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "4") break;

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                _ => null
            };

            if (activity != null) ((dynamic)activity).Run();
        }

    }
}