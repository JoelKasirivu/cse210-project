class EternalGoal : Goal
// Represents a goal that can be recorded multiple times without completion
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    { }
// Constructor to initialize the eternal goal with a name, description, and points

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for '{_shortName}'. Keep going!");
    }
}