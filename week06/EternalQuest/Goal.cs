using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    protected string name;
    protected int points;
    protected bool isCompleted;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        this.isCompleted = false;
    }

    public abstract void RecordProgress();
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Goal: {name} | Completed: {(isCompleted ? "[X]" : "[ ]")}");
    }

    public int GetPoints() => points;
}
