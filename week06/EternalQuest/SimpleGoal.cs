class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordProgress()
    {
        isCompleted = true;
        Console.WriteLine($"Completed '{name}'! You earned {points} points.");
    }
}
