class ChecklistGoal : Goal
// This class represents a checklist goal that requires multiple completions to achieve.
// It inherits from the Goal class and implements the RecordProgress method.
{
    // ChecklistGoal class inherits from Goal and represents a goal that requires multiple completions.
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
// Constructor for ChecklistGoal that initializes the goal with a name, points, target count, and bonus points.
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.currentCount = 0;
    }

    public override void RecordProgress()
    // Method to record progress on the checklist goal
    // This method increments the current count, checks if the target is reached,
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
    // Method to display the current status of the checklist goal
    // This method shows the goal name, current count, target count, and completion status.
    {
        Console.WriteLine($"Goal: {name} | Progress: {currentCount}/{targetCount} | Completed: {(isCompleted ? "[X]" : "[ ]")}");
    }
}

