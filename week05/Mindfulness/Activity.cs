using System;
using System.Threading;

class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {Name}...");
        Console.WriteLine(Description);
        Console.Write("Enter duration (seconds): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Pause();
    }

    public void EndActivity()
    {
        Console.WriteLine($"Good job! You completed the {Name} activity for {Duration} seconds.");
        Pause();
    }

    protected void Pause()
    {
        Console.Write("Pausing...");
        for (int i = 3; i > 0; i--)
        {
            Console.Write($" {i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
