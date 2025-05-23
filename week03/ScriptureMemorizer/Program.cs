using System;

class Program
{
    static void Main()
    {
        ScriptureReference reference = new ScriptureReference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == "quit") break;
            if (!scripture.HideRandomWords()) break;
        }

        Console.WriteLine("\nAll words hidden! Memorization complete.");
    }
}