using System.Collections.Generic;

class ReflectionActivity : Activity
// This class represents a reflection activity that prompts the user to think about meaningful experiences.
// It inherits from the Activity class and implements the Run method to guide the user through reflection questions.
{
    private List<string> Prompts = new List<string>
    // Prompts for the reflection activity
    // These prompts are designed to encourage the user to reflect on their past experiences and personal growth.
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> Questions = new List<string>
    // Questions to guide the user through reflection
    // These questions are intended to help the user delve deeper into their thoughts and feelings about the experiences they reflect on.
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity() : base("Reflection Activity", 
        "This activity will help you reflect on moments of strength and resilience.") {}
        // Constructor initializes the activity with a name and description.
// The description explains that this activity will guide the user to think about their strengths and resilience through reflection.

    public void Run()
    // This method runs the reflection activity.
    // It starts the activity, presents a random prompt, and then asks the user a series of reflection questions.
    {
        StartActivity();
        Random rnd = new Random();
        Console.WriteLine(Prompts[rnd.Next(Prompts.Count)]);

        foreach (string question in Questions)
        {
            Console.WriteLine(question);
            Pause();
        }
        EndActivity();
    }
}
// This class represents a reflection activity that prompts the user to think about meaningful experiences.
// It inherits from the Activity class and implements the Run method to guide the user through reflection questions.