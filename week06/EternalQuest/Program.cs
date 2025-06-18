class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create New Goal\n2. Record Progress\n3. Show Goals\n4. Show Score\n5. Save & Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordProgress(); break;
                case "3": ShowGoals(); break;
                case "4": Console.WriteLine($"Total Score: {totalScore} points"); break;
                case "5": SaveGoals(); return;
                default: Console.WriteLine("Invalid choice. Try again."); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Choose goal type: (1) Simple (2) Eternal (3) Checklist");
        string type = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1": goals.Add(new SimpleGoal(name, points)); break;
            case "2": goals.Add(new EternalGoal(name, points)); break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default: Console.WriteLine("Invalid choice."); break;
        }
    }

    static void RecordProgress()
    {
        ShowGoals();
        Console.Write("Enter goal number to record progress: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordProgress();
            totalScore += goals[index].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    static void ShowGoals()
    {
        Console.WriteLine("\nCurrent Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayStatus();
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(totalScore);
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.GetPoints()}");
            }
        }
        Console.WriteLine("Goals saved!");
    }
}
