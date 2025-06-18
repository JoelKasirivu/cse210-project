class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.currentCount = 0;
    }

    public override void RecordProgress()
    {
        currentCount++;
        Console.WriteLine($"Recorded '{name}' ({currentCount}/{targetCount}). You earned {points} points.");
        if (currentCount == targetCount)
        {
            isCompleted = true;
            Console.WriteLine($"Congratulations! You completed '{name}' and earned a bonus of {bonusPoints} points.");
        }
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"Goal: {name} | Progress: {currentCount}/{targetCount} | Completed: {(isCompleted ? "[X]" : "[ ]")}");
    }
}

