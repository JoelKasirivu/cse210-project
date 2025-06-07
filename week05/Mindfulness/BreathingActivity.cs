class BreathingActivity : Activity
// This class represents a breathing activity that guides the user to breathe in and out slowly.
// It inherits from the Activity class and implements the Run method to perform the breathing exercise.
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by guiding you to breathe in and out slowly.") {}
        // Constructor initializes the activity with a name and description.

    public void Run()
    // This method runs the breathing activity.
    // It starts the activity, guides the user through breathing in and out for a specified duration,
    {
        StartActivity();
        for (int i = 0; i < Duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Pause();
            Console.WriteLine("Breathe out...");
            Pause();
        }
        EndActivity();
    }
}
// This class represents a breathing activity that guides the user to breathe in and out slowly.
// It inherits from the Activity class and implements the Run method to perform the breathing exercise.