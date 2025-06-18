class EternalGoal : Goal
// This class represents an eternal goal that can be completed multiple times.
// It inherits from the Goal class and implements the RecordProgress method.
{
    public EternalGoal(string name, int points) : base(name, points) { }
    // EternalGoal class inherits from Goal and represents a goal that can be completed multiple times.

    public override void RecordProgress()
    // Method to record progress on the eternal goal
    // This method marks the goal as completed and awards points.
    {
        Console.WriteLine($"Recorded '{name}'. You earned {points} points.");
    }
}
