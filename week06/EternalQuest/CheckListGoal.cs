class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    // Represents a goal that requires completing a checklist of tasks
// This class extends the Goal class and adds functionality for tracking multiple completions

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
        // Constructor to initialize the checklist goal with a name, description, points, target, and bonus
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    // Method to record an event for the checklist goal
    // This method increments the amount completed and checks if the target is reached
    {
        _amountCompleted++;
        Console.WriteLine($"Progress: {_amountCompleted}/{_target} for '{_shortName}'");

        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Checklist Goal '{_shortName}' completed! Bonus: {_bonus} pts");
        }

    }

    public override string GetDetailsString()
    // Method to get a string representation of the checklist goal's details
    {
        return $"{_shortName}: {_description} ({_points} pts, {_amountCompleted}/{_target} completed)";
    }
}