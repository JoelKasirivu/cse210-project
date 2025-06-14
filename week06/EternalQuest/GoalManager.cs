class GoalManager
{
    
    private List<Goal> _goals;
    // List to hold all active goals
    private int _score;
    // Current score based on completed goals

    public GoalManager()
    
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    // Adds a new goal to the list of active goals
    // This method takes a Goal object and adds it to the _goals list
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    // Displays all active goals with their details
    // This method iterates through the list of goals and prints their details
    {
        Console.WriteLine("\nActive Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void RecordEvent(string goalName)
    // Records an event for a specific goal by its name
    // This method searches for a goal by its name and records an event if found
    {
        foreach (Goal goal in _goals)
        {
            if (goal.GetDetailsString().Contains(goalName))
            {
                goal.RecordEvent();
                _score += goal.GetPoints();
                Console.WriteLine($"Current Score: {_score}");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }
}