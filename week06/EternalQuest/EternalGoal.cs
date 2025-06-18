class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordProgress()
    {
        Console.WriteLine($"Recorded '{name}'. You earned {points} points.");
    }
}
