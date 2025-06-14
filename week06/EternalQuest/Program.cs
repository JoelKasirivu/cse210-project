using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();
        // Create an instance of GoalManager to manage goals
        

        manager.AddGoal(new SimpleGoal("Read Book", "Finish reading a book", 100));
        manager.AddGoal(new EternalGoal("Exercise", "Stay fit!", 50));
        manager.AddGoal(new ChecklistGoal("Study Sessions", "Complete study goals", 200, 5, 500));

        manager.DisplayGoals();
        // Display all active goals
        // This will print the details of each goal added to the manager

        Console.WriteLine("\nRecording event for 'Read Book'...");
        manager.RecordEvent("Read Book");

        Console.WriteLine("\nRecording event for 'Exercise'...");
        manager.RecordEvent("Exercise");

        Console.WriteLine("\nRecording event for 'Study Sessions'...");
        manager.RecordEvent("Study Sessions");

    }
}
