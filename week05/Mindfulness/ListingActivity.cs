using System.Collections.Generic;

class ListingActivity : Activity
// This class represents a listing activity that prompts the user to list items related to a given prompt.
// It inherits from the Activity class and implements the Run method to collect user input until the duration ends.
{
    private List<string> Prompts = new List<string>
    // Prompts for the listing activity
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by listing them.") {}
        // Constructor initializes the activity with a name and description.
    // The description explains that this activity will help the user reflect on positive aspects of their life.

    public void Run()
    // This method runs the listing activity.
    // It starts the activity, prompts the user to list items related to a random prompt,
    {
        StartActivity();
        Random rnd = new Random();
        Console.WriteLine(Prompts[rnd.Next(Prompts.Count)]);

        Console.WriteLine("Start listing items:");
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items!");
        EndActivity();
    }
}
// This class represents a listing activity that prompts the user to list items related to a given prompt.
// It inherits from the Activity class and implements the Run method to collect user input until the duration ends.