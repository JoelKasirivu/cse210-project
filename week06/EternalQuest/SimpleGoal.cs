class SimpleGoal : Goal
// Represents a simple goal that can be completed once
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    // Constructor to initialize the simple goal with a name, description, and points
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Goal '{_shortName}' completed!");
    }

    public bool IsComplete() => _isComplete;
}