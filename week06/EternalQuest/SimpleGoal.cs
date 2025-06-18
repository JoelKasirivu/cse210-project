class SimpleGoal : Goal
// This class represents a simple goal that can be completed once.
// It inherits from the Goal class and implements the RecordProgress method.
{
    public SimpleGoal(string name, int points) : base(name, points) { }
    // SimpleGoal class inherits from Goal and represents a basic goal that can be completed once.

    public override void RecordProgress()
    // Method to record progress on the simple goal
    {
        isCompleted = true;
        Console.WriteLine($"Completed '{name}'! You earned {points} points.");
    }
}
